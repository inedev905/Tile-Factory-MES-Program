using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DTO;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace Team2_Project_DAO
{
    public class UserCodeDAO : IDisposable
    {
        SqlConnection conn;

        public UserCodeDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }
        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<UserCodeDTO> GetUserCode()
        {
            try
            {
                string sql = @"select ma.Userdefine_Ma_Code, Userdefine_Ma_Name, 
                                    isnull(Userdefine_Mi_Code, '') Userdefine_Mi_Code, 
                                    isnull(Userdefine_Mi_Name, '') Userdefine_Mi_Name,
                                    Sort_Index, mi.Remark,
                                    isnull((case when mi.Use_YN = 'Y' then '예'
										when mi.Use_YN = 'N' then '아니오' end), '') as Use_YN
                            from Userdefine_Mi_Master mi right outer join Userdefine_Ma_Master ma 
                                                        on mi.Userdefine_Ma_Code = ma.Userdefine_Ma_Code and ma.Use_YN = 'Y'";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    List<UserCodeDTO> list = Helper.DataReaderMapToList<UserCodeDTO>(cmd.ExecuteReader());
                    conn.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public bool CheckPK(string maCode, string miCode)
        {
            try
            {
                string sql = @"select count(*) cnt
                                from Userdefine_Mi_Master
                                where Userdefine_Ma_Code = @Userdefine_Ma_Code and Userdefine_Mi_Code = @Userdefine_Mi_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Userdefine_Mi_Code", miCode);
                    cmd.Parameters.AddWithValue("@Userdefine_Ma_Code", maCode);

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

        public bool InsertUserCode(UserCodeDTO code)
        {
            try
            {
                string sql = @"insert into Userdefine_Mi_Master(Userdefine_Mi_Code, Userdefine_Ma_Code, Userdefine_Mi_Name, 
                                            Sort_Index, Remark, Use_YN, Ins_Emp)
                                    values (@Userdefine_Mi_Code, @Userdefine_Ma_Code, @Userdefine_Mi_Name, 
                                            @Sort_Index, @Remark, @Use_YN, @Ins_Emp)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Userdefine_Mi_Code", code.Userdefine_Mi_Code);
                    cmd.Parameters.AddWithValue("@Userdefine_Ma_Code", code.Userdefine_Ma_Code);
                    cmd.Parameters.AddWithValue("@Userdefine_Mi_Name", code.Userdefine_Mi_Name);
                    cmd.Parameters.AddWithValue("@Sort_Index", code.Sort_Index);
                    cmd.Parameters.AddWithValue("@Remark", code.Remark);
                    cmd.Parameters.AddWithValue("@Use_YN", code.Use_YN);
                    cmd.Parameters.AddWithValue("@Ins_Emp", code.Ins_Emp);

                    conn.Open();
                    int iRowAffect = cmd.ExecuteNonQuery();
                    conn.Close();

                    return (iRowAffect > 0);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public bool UpdateUserCode(UserCodeDTO code)
        {
            try
            {
                string sql = @"update Userdefine_Mi_Master
                                set Userdefine_Mi_Name = @Userdefine_Mi_Name, 
	                                Sort_Index = @Sort_Index, 
	                                Remark = @Remark, 
	                                Use_YN = @Use_YN, 
	                                Up_Date = GETDATE(),
	                                Up_Emp = @Up_Emp
                                where Userdefine_Ma_Code = @Userdefine_Ma_Code and Userdefine_Mi_Code = @Userdefine_Mi_Code";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {                    
                    cmd.Parameters.AddWithValue("@Userdefine_Mi_Name", code.Userdefine_Mi_Name);
                    cmd.Parameters.AddWithValue("@Sort_Index", code.Sort_Index);
                    cmd.Parameters.AddWithValue("@Remark", code.Remark);
                    cmd.Parameters.AddWithValue("@Use_YN", code.Use_YN);
                    cmd.Parameters.AddWithValue("@Up_Emp", code.Up_Emp);
                    cmd.Parameters.AddWithValue("@Userdefine_Ma_Code", code.Userdefine_Ma_Code);
                    cmd.Parameters.AddWithValue("@Userdefine_Mi_Code", code.Userdefine_Mi_Code);
                    
                    conn.Open();
                    int iRowAffect = cmd.ExecuteNonQuery();
                    conn.Close();

                    return (iRowAffect > 0);
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public int DeleteUserCode(string maCode, string miCode)
        {
            try
            {
                string sql = @"delete from Userdefine_Mi_Master
                                where Userdefine_Ma_Code = @Userdefine_Ma_Code and Userdefine_Mi_Code = @Userdefine_Mi_Code;
                                select @@ERROR";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Userdefine_Mi_Code", miCode);
                    cmd.Parameters.AddWithValue("@Userdefine_Ma_Code", maCode);

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
    }
}
