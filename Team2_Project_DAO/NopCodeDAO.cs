using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Team2_Project_DTO;

namespace Team2_Project_DAO
{
    public class NopCodeDAO : IDisposable
    {
        SqlConnection conn;
        public NopCodeDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<NopMaCodeDTO> GetNopMaSearch(NopMaCodeDTO item) //비가동 대분류코드 조회
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                //sb.Append("SP_OrderList");
                sb.Append(@"SELECT Nop_Ma_Code, Nop_Ma_Name
                                 , CASE WHEN Use_YN = 'Y' THEN '예' ELSE '아니오' END AS Use_YN
	                             , CONVERT(VARCHAR(10), Ins_Date, 23) Ins_Date	                               
                             FROM Nop_Ma_Master
                            WHERE 1 = 1");   // , Ins_Emp , CONVERT(VARCHAR(10), Up_Date, 23) Up_Date , Up_Emp

                if (!string.IsNullOrWhiteSpace(item.Nop_Ma_Code))
                {
                    sb.Append(" AND Nop_Ma_Code LIKE @Nop_Ma_Code");
                    cmd.Parameters.AddWithValue("@Nop_Ma_Code", "%" + item.Nop_Ma_Code + "%");
                }
                if (!string.IsNullOrWhiteSpace(item.Nop_Ma_Name))
                {
                    sb.Append(" AND Nop_Ma_Name LIKE @Nop_Ma_Name");
                    cmd.Parameters.AddWithValue("@Nop_Ma_Name", "%" + item.Nop_Ma_Name + "%");
                }

                if (item.Use_YN == "예") sb.Append(" AND Use_YN = 'Y'");
                else if (item.Use_YN == "아니오") sb.Append(" AND Use_YN = 'N'");

                sb.Append(" ORDER BY Nop_Ma_Code");

                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                conn.Open();
                Debug.WriteLine(cmd.CommandText);
                List<NopMaCodeDTO> list = Helper.DataReaderMapToList<NopMaCodeDTO>(cmd.ExecuteReader());

                return list;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool NopMaCodeAdd(NopMaCodeDTO item) //대분류 추가
        {
            try
            {
                string sql = @"INSERT INTO Nop_Ma_Master(Nop_Ma_Code , Nop_Ma_Name, Use_YN, Ins_Emp, Ins_Date) 
                                               VALUES (@Nop_Ma_Code , @Nop_Ma_Name, @Use_YN, @Ins_Emp, GETDATE())";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", item.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Nop_Ma_Name", item.Nop_Ma_Name);
                cmd.Parameters.AddWithValue("@Use_YN", item.Use_YN);
                cmd.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);

                conn.Open();
                Debug.WriteLine(item.Use_YN);
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<NopMaCodeDTO> GetMaCurItem(string item) //대분류 패널로드
        {
            try
            {
                string sql = @"SELECT Nop_Ma_Code , Nop_Ma_Name, Use_YN                          
                                 FROM Nop_Ma_Master 
                                WHERE Nop_Ma_Code = @Nop_Ma_Code";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", item);
                cmd.Connection = conn;

                conn.Open();
                Debug.WriteLine(cmd.CommandText);
                List<NopMaCodeDTO> list = Helper.DataReaderMapToList<NopMaCodeDTO>(cmd.ExecuteReader());
                return list;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool NopMaCodeUpdate(NopMaCodeDTO item) //대분류 수정
        {
            try
            {
                string sql = @"UPDATE Nop_Ma_Master
                                  SET Nop_Ma_Name = @Nop_Ma_Name, Use_YN = @Use_YN, Up_Date = GETDATE(), Up_Emp = @Up_Emp
                                WHERE Nop_Ma_Code = @Nop_Ma_Code";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", item.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Nop_Ma_Name", item.Nop_Ma_Name);
                cmd.Parameters.AddWithValue("@Use_YN", item.Use_YN);
                cmd.Parameters.AddWithValue("@Up_Emp", item.Up_Emp);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool CheckPK(string Code) //PK체크
        {
            try
            {
                string sql = @"SELECT count(*) cnt
                                FROM Nop_Ma_Master
                                WHERE Nop_Ma_Code = @Nop_Ma_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Nop_Ma_Code", Code);
                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return (cnt < 1);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public bool CheckMiPK(string Code) //PK체크
        {
            try
            {
                string sql = @"SELECT count(*) cnt
                                FROM Nop_Mi_Master
                                WHERE Nop_Mi_Code = @Nop_Mi_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Nop_Mi_Code", Code);
                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return (cnt < 1);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }


        public int DeleteMaCode(string Code)
        {
            try
            {
                string sql = @"DELETE FROM Nop_Ma_Master
                                WHERE Nop_Ma_Code = @Nop_Ma_Code;
                                SELECT @@ERROR";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Nop_Ma_Code", Code);

                    Debug.WriteLine(cmd.CommandText);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return result;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return -1;
            }
        }

        public int DeleteMiCode(string Code)
        {
            try
            {
                string sql = @"DELETE FROM Nop_Mi_Master
                                WHERE Nop_Mi_Code = @Nop_Mi_Code;
                                SELECT @@ERROR";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Nop_Mi_Code", Code);

                    Debug.WriteLine(cmd.CommandText);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return result;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return -1;
            }
        }


        //----------------
        //--  상세분류  --
        //----------------

        public List<NopMiCodeDTO> GetNopMiSearch(NopMiCodeDTO item) //비가동 상세분류코드 조회
        {
            try
            {
                string sql = @"SELECT MA.Nop_Ma_Code, MA.Nop_Ma_Name, MI.Nop_Mi_Code, MI.Nop_Mi_Name, MI.Nop_type, 
	                                CASE WHEN MI.Use_YN = 'Y' THEN '예' ELSE '아니오' END AS Use_YN, MI.Ins_Emp
	                                , CONVERT(VARCHAR(10), MI.Ins_Date, 23) Ins_Date 
	                                , CONVERT(VARCHAR(10), MI.Up_Date, 23) Ins_Date	, MI.Up_Emp
                                FROM Nop_Ma_Master MA LEFT OUTER JOIN Nop_Mi_Master MI ON MA.Nop_Ma_Code = MI.Nop_Ma_Code
                                WHERE 1 = 1";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    Debug.WriteLine(cmd.CommandText);
                    List<NopMiCodeDTO> list = Helper.DataReaderMapToList<NopMiCodeDTO>(cmd.ExecuteReader());
                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool NopMiCodeAdd(NopMiCodeDTO item) //상세분류 추가
        {
            try
            {
                string sql = @"INSERT INTO Nop_Mi_Master(Nop_Mi_Code , Nop_Mi_Name, Nop_Ma_Code, Nop_type, Use_YN,Ins_Emp, Ins_Date) 
                                               VALUES (@Nop_Mi_Code , @Nop_Mi_Name, @Nop_Ma_Code, @Nop_type, @Use_YN, @Ins_Emp, GETDATE())";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nop_Mi_Code", item.Nop_Mi_Code);
                cmd.Parameters.AddWithValue("@Nop_Mi_Name", item.Nop_Mi_Name);
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", item.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Nop_type", item.Nop_type);
                cmd.Parameters.AddWithValue("@Use_YN", item.Use_YN);
                cmd.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);

                conn.Open();
                Debug.WriteLine(cmd.CommandText);
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool NopMiCodeUpdate(NopMiCodeDTO item) //상세분류 수정
        {
            try
            {
                string sql = @"UPDATE Nop_Mi_Master
                                  SET Nop_Mi_Name = @Nop_Mi_Name, Nop_type = @Nop_type, Use_YN = @Use_YN, Up_Date = GETDATE(), Up_Emp = @Up_Emp
                                WHERE Nop_Mi_Code = @Nop_Mi_Code";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nop_Mi_Code", item.Nop_Mi_Code);
                cmd.Parameters.AddWithValue("@Nop_Mi_Name", item.Nop_Mi_Name);
                cmd.Parameters.AddWithValue("@Nop_type", item.Nop_type);
                cmd.Parameters.AddWithValue("@Use_YN", item.Use_YN);
                cmd.Parameters.AddWithValue("@Up_Emp", item.Up_Emp);

                conn.Open();
                Debug.WriteLine(cmd.CommandText);
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
