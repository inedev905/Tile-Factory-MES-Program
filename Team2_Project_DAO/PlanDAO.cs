using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DTO;

namespace Team2_Project_DAO
{
    public class PlanDAO : IDisposable
    {
        SqlConnection conn;

        public PlanDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable GetPlanReq(string from, string to)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_GetPrdReq", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@from", from);
                da.SelectCommand.Parameters.AddWithValue("@to", to);

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();

                return dt;

            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public bool InsertPlan(List<PlanDTO> plans)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_InsertPlan", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Emp", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Plan_Qty", SqlDbType.Int);
                    cmd.Parameters.Add("@Plan_Rest_Qty", SqlDbType.Int);
                    cmd.Parameters.Add("@Prd_Req_No", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Item_Code", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Wc_Code", SqlDbType.NVarChar);

                    cmd.Parameters.Add("@PO_CD", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PO_MSG", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;

                    foreach (var plan in plans)
                    {
                        cmd.Parameters["@Emp"].Value = plan.Ins_Emp;
                        cmd.Parameters["@Plan_Qty"].Value = plan.Plan_Qty;
                        cmd.Parameters["@Plan_Rest_Qty"].Value = plan.Plan_Rest_Qty;
                        cmd.Parameters["@Prd_Req_No"].Value = plan.Prd_Req_No;
                        cmd.Parameters["@Item_Code"].Value = plan.Item_Code;
                        cmd.Parameters["@Wc_Code"].Value = plan.Wc_Code;

                        cmd.ExecuteNonQuery();

                        string pMsg = cmd.Parameters["@PO_MSG"].Value.ToString();
                        int pCode = Convert.ToInt32(cmd.Parameters["@PO_CD"].Value);
                        if (pCode < 0)
                        {
                            throw new Exception(pMsg);
                        }
                    }

                    conn.Close();
                    return true;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }
    
    }
}
