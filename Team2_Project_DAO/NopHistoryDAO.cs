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
    public class NopHistoryDAO : IDisposable
    {
        SqlConnection conn;
        public NopHistoryDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<NopHistoryDTO> GetNopMiSearch(NopHistoryDTO item) //비가동이력 조회
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                sb.Append(@"SELECT NH.Nop_Seq
                                 , CONVERT(VARCHAR(10), NH.Nop_Date, 23) Nop_Date
	                             , CONVERT(VARCHAR(23), NH.Nop_HappenTime, 21) Nop_HappenTime
	                             , CONVERT(VARCHAR(23), NH.Nop_CancelTime, 21) Nop_CancelTime, NH.Nop_Time, NH.Nop_Mi_Code, NH.Wc_Code 
	                             , WM.Wc_Name, WM.Wc_Group, WM.Process_Code
	                             , PM.Process_Name
	                             , MI.Nop_Mi_Name, MI.Nop_Ma_Code, MI.Nop_type, MI.Use_YN
	                             , MA.Nop_Ma_Name
                             FROM Nop_History NH  INNER JOIN WorkCenter_Master WM ON NH.Wc_Code = WM.Wc_Code
						                          INNER JOIN Process_Master PM ON WM.Process_Code = PM.Process_Code
						                          INNER JOIN Nop_Mi_Master MI ON NH.Nop_Mi_Code = MI.Nop_Mi_Code
						                          INNER JOIN Nop_Ma_Master MA ON MI.Nop_Ma_Code = MA.Nop_Ma_Code
                            WHERE 1 = 1
                              AND MI.Nop_Ma_Code LIKE @Ma_Code
                              AND MA.Nop_Ma_Name LIKE @Ma_Name
                              AND NH.Nop_Date >= @DateFrom AND NH.Nop_Date < @DateTo");

                cmd.Parameters.AddWithValue("@DateFrom", item.DateFrom);
                cmd.Parameters.AddWithValue("@DateTo", item.DateTo);

                if (string.IsNullOrWhiteSpace(item.Nop_Ma_Code)) cmd.Parameters.AddWithValue("@Ma_Code", $"%%");
                else cmd.Parameters.AddWithValue("@Ma_Code", $"%{item.Nop_Ma_Code}%");

                if (string.IsNullOrWhiteSpace(item.Nop_Ma_Name)) cmd.Parameters.AddWithValue("@Ma_Name", $"%%");
                else cmd.Parameters.AddWithValue("@Ma_Name", $"%{item.Nop_Ma_Name}%");

                sb.Append(" ORDER BY NH.Nop_Seq");

                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                conn.Open();
                Debug.WriteLine(cmd.CommandText);
                List<NopHistoryDTO> list = Helper.DataReaderMapToList<NopHistoryDTO>(cmd.ExecuteReader());
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

    }
}
