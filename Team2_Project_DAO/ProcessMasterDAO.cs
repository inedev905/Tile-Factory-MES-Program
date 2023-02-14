using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Team2_Project_DTO;
using System.Diagnostics;

namespace Team2_Project_DAO
{
    public class ProcessMasterDAO : IDisposable
    {
        string connStr = null;
        SqlConnection conn;

        public ProcessMasterDAO()
        {
            connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connStr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<ProcessMasterDTO> SetProcessList()
        {
            try
            {
                string sql = @"select Process_Code, Process_Name, Process_Group, case when Use_YN = 'Y' then '예'
                                    when Use_YN = 'N' then '아니요' end as Use_YN, Remark from Process_Master";

                SqlCommand cmd = new SqlCommand(sql,conn);
                conn.Open();
                List<ProcessMasterDTO> list = Helper.DataReaderMapToList<ProcessMasterDTO>(cmd.ExecuteReader());
                conn.Close();
                return list;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public List<ProcessMasterDTO> InputProcess(ProcessMasterDTO newProcess)
        {
            string sql = @"INSERT INTO Process_Master (Process_Code, Process_Name, Process_Group, Use_YN, Remark, Ins_Emp, Ins_Date, Up_Emp, Up_Date) 
                                            VALUES(@Process_Code, @Process_Name, @Process_Group, @Use_YN, @Remark, @Ins_Emp, @Ins_Date, @Up_Emp, @Up_Date)";
            string sql2 = @"select Process_Code, Process_Name, Process_Group, case when Use_YN = 'Y' then '예'
                                    when Use_YN = 'N' then '아니요' end as Use_YN, Remark from Process_Master";
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Process_Code",newProcess.Process_Code);
                cmd.Parameters.AddWithValue("@Process_Name",newProcess.Process_Name);
                cmd.Parameters.AddWithValue("@Process_Group",newProcess.Process_Group);
                cmd.Parameters.AddWithValue("@Use_YN",newProcess.Use_YN);
                cmd.Parameters.AddWithValue("@Remark",newProcess.Remark);
                cmd.Parameters.AddWithValue("@Ins_Emp", newProcess.Up_Emp);
                cmd.Parameters.AddWithValue("@Ins_Date", newProcess.Up_Date);
                cmd.Parameters.AddWithValue("@Up_Emp", newProcess.Up_Emp);
                cmd.Parameters.AddWithValue("@Up_Date", newProcess.Up_Date);
                trans.Commit();
                if (cmd.ExecuteNonQuery() < 0)
                    return null;
                
                cmd.Parameters.Clear();
                cmd.Connection = conn;
                cmd.CommandText = sql2;
                List<ProcessMasterDTO> list = Helper.DataReaderMapToList<ProcessMasterDTO>(cmd.ExecuteReader());
                
                conn.Close();
                trans.Dispose();

                return list;
            }
            catch (Exception err)
            {
                trans.Rollback();
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public List<ProcessMasterDTO> EditProcess(ProcessMasterDTO editProcess)
        {
            string sql = @"UPDATE Process_Master
                                SET Process_Name = @Process_Name, Process_Group = @Process_Group, Remark = @Remark, Use_YN = @Use_YN, Up_Emp = @Up_Emp, Up_Date = @Up_Date
                                WHERE Process_Code = @Process_Code";
            string sql2 = @"select Process_Code, Process_Name, Process_Group, case when Use_YN = 'Y' then '예'
                                    when Use_YN = 'N' then '아니요' end as Use_YN, Remark from Process_Master";
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@Process_Code", editProcess.Process_Code);
                cmd.Parameters.AddWithValue("@Process_Name", editProcess.Process_Name);
                cmd.Parameters.AddWithValue("@Process_Group", editProcess.Process_Group);
                cmd.Parameters.AddWithValue("@Use_YN", editProcess.Use_YN);
                cmd.Parameters.AddWithValue("@Remark", editProcess.Remark);
                cmd.Parameters.AddWithValue("@Up_Emp", editProcess.Up_Emp);
                cmd.Parameters.AddWithValue("@Up_Date", editProcess.Up_Date);
                trans.Commit();
                if (cmd.ExecuteNonQuery() < 0)
                    return null;

                cmd.Parameters.Clear();
                cmd.CommandText = sql2;
                List<ProcessMasterDTO> list = Helper.DataReaderMapToList<ProcessMasterDTO>(cmd.ExecuteReader());

                conn.Close();
                trans.Dispose();

                return list;
            }
            catch (Exception err)
            {
                trans.Rollback();
                Debug.WriteLine(err.Message);
                return null;
            }
        }
        public List<ProcessMasterDTO> DelProcess(string txtProcessCode)
        {
            string sql = "Delete from Process_Master where Process_Code = @Process_Code";
            string sql2 = @"select Process_Code, Process_Name, Process_Group, case when Use_YN = 'Y' then '예'
                                    when Use_YN = 'N' then '아니요' end as Use_YN, Remark from Process_Master";
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@Process_Code", txtProcessCode);
                trans.Commit();
                if (cmd.ExecuteNonQuery() < 0)
                    return null;

                cmd.Parameters.Clear();
                cmd.CommandText = sql2;
                List<ProcessMasterDTO> list = Helper.DataReaderMapToList<ProcessMasterDTO>(cmd.ExecuteReader());

                conn.Close();
                trans.Dispose();

                return list;
            }
            catch (Exception err)
            {
                trans.Rollback();
                Debug.WriteLine(err.Message);
                return null;
            }
        }
    }
}
