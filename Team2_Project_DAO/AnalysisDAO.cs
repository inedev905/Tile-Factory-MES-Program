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
    public class AnalysisDAO : IDisposable
    {
        SqlConnection conn;
        public AnalysisDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        
        public List<TimeProductionHistoryDTO> GetWorkOrder(string from, string to) //날짜기준으로 시간대별실적 (작업조회기준) 데이터 가져오기
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_TimeProductionHistory";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PrdDateFrom", from);
                    cmd.Parameters.AddWithValue("@PrdDateTo", to);

                    SqlDataReader reader = cmd.ExecuteReader();
                    List<TimeProductionHistoryDTO> list = Helper.DataReaderMapToList<TimeProductionHistoryDTO>(reader);
                    reader.Close();

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


        public List<TimeProductionHistoryDTO> GetTimeProductionHistory() //시간대별 데이터
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_TIMETEST";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<TimeProductionHistoryDTO> list = Helper.DataReaderMapToList<TimeProductionHistoryDTO>(reader);
                    reader.Close();

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
    }
}
