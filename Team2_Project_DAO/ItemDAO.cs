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
    public class ItemDAO : IDisposable
    {
        SqlConnection conn;
        public ItemDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<ItemDTO> GetItemSearch(ItemDTO item) //품목조회
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                //sb.Append("SP_OrderList");
                sb.Append(@"SELECT Item_Code , Item_Name
                                 , CASE WHEN Item_Type = 'PR' THEN '완제품' ELSE '반제품' END AS Item_Type
                                 , CASE WHEN Use_YN = 'Y' THEN '예' ELSE '아니오' END AS Use_YN
                                 , Item_Spec , Remark , Use_YN 
	                             , CONVERT(VARCHAR(10), Ins_Date, 23) Ins_Date	                               
                             FROM Item_Master
                            WHERE 1 = 1");

                if (!string.IsNullOrWhiteSpace(item.Item_Code))
                {
                    sb.Append(" AND Item_Code LIKE @Item_Code");
                    cmd.Parameters.AddWithValue("@Item_Code", $"%{item.Item_Code}%");
                }
                if (!string.IsNullOrWhiteSpace(item.Item_Name))
                {
                    sb.Append(" AND Item_Name LIKE @Item_Name");
                    cmd.Parameters.AddWithValue("@Item_Name", $"%{item.Item_Name}%");
                }

                if (item.Item_Type == "완제품") sb.Append(" AND Item_Type = 'PR'");
                else if (item.Item_Type.ToString() == "반제품") sb.Append(" AND Item_Type = 'SA'");

                if (item.Use_YN == "예") sb.Append(" AND Use_YN = 'Y'");
                else if (item.Use_YN == "아니오") sb.Append(" AND Use_YN = 'N'");

                sb.Append(" ORDER BY Item_Code");
                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemDTO> list = Helper.DataReaderMapToList<ItemDTO>(reader);
                reader.Close(); 
                return list;
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool GetItemAdd(ItemDTO item) //품목추가
        {
            try
            {                
                string sql = @"INSERT INTO Item_Master(Item_Code , Item_Name , Item_Type , Item_Spec , Remark , Ins_Emp, Ins_Date) 
                                               VALUES (@Item_Code , @Item_Name , @Item_Type , @Item_Spec , @Remark , @Ins_Emp, GETDATE())";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@Item_Code", item.Item_Code); /////////////////////////// 추후 자동발행
                cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);
                cmd.Parameters.AddWithValue("@Item_Type", item.Item_Type);

                cmd.Parameters.AddWithValue("@Item_Spec", item.Item_Spec);
                cmd.Parameters.AddWithValue("@Use_YN", item.Use_YN);
                cmd.Parameters.AddWithValue("@Remark", item.Remark);
                cmd.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);

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

        public List<ItemDTO> GetCurItem(string item) //품목 패널로드 //미사용
        {
            try
            {               
                string sql = @"SELECT Item_Code , Item_Name , Item_Type , Item_Spec , Use_YN, Remark 	                               
                                 FROM Item_Master 
                                WHERE Item_Code = @Item_Code";
                SqlCommand cmd = new SqlCommand(sql, conn) ;
                cmd.Parameters.AddWithValue("@Item_Code", item);
                cmd.Connection = conn;

                conn.Open();
                Debug.WriteLine(cmd.CommandText);
                List<ItemDTO> list = Helper.DataReaderMapToList<ItemDTO>(cmd.ExecuteReader());
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

        public bool GetItemUpdate(ItemDTO item) //품목수정
        {        
            try
            {
                string sql = @"UPDATE Item_Master
                                  SET Item_Name = @Item_Name
                                    , Item_Type = @Item_Type
                                    , Item_Spec = @Item_Spec
                                    , Remark = @Remark
                                    , Use_YN = @Use_YN
                                    , Up_Date = GETDATE()
                                    , Up_Emp = @Up_Emp
                                WHERE Item_Code = @Item_Code";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Item_Code", item.Item_Code);
                cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);
                cmd.Parameters.AddWithValue("@Item_Type", item.Item_Type);
                cmd.Parameters.AddWithValue("@Item_Spec", item.Item_Spec);
                cmd.Parameters.AddWithValue("@Use_YN", item.Use_YN);
                cmd.Parameters.AddWithValue("@Remark", item.Remark);
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

        public bool CheckPK(string ItemCode) //PK체크
        {
            try
            {
                string sql = @"SELECT count(*) cnt
                                FROM Item_Master
                                WHERE Item_Code = @Item_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Item_Code", ItemCode);

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

        public int DeleteItemCode(string Code)
        {
            try
            {
                string sql = @"DELETE FROM Item_Master
                                WHERE Item_Code = @Item_Code;
                                SELECT @@ERROR";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Item_Code", Code);

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

        public List<CodeDTO> GetCode(string txt) //완제품/반제품 //값 안뜸
        {
            try
            {
                string sql = @"SELECT Sys_Ma_Code, Sys_Mi_Code, Sys_Mi_Name
                                FROM Sys_Mi_Master
                                WHERE Sys_Ma_Code = @txt";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@txt", txt);
                conn.Open();
                List<CodeDTO> list = Helper.DataReaderMapToList<CodeDTO>(cmd.ExecuteReader());
                conn.Close();
                return list;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }
        }




        // 완제품 코드랑 이름만 가져오는 코드 - 0124 이승원
        public List<ItemDTO> GetItemCodeName()
        {
            string sql = @"select Item_Code, Item_Name FROM Item_Master
                            WHERE Use_YN = 'Y'";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                List<ItemDTO> list = Helper.DataReaderMapToList<ItemDTO>(cmd.ExecuteReader());
                conn.Close();

                return list;
            }
        }
    }
}
