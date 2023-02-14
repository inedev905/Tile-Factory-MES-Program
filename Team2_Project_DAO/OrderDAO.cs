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
    public class OrderDAO : IDisposable
    {
        string connStr = null;
        SqlConnection conn;

        public OrderDAO()
        {
            connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable GetOrderList(string[] list)
        {
            try
            {
                string sql = @"select Prd_Req_No, convert(nvarchar(10), Req_Date, 23) Req_Date, Req_Seq, pr.Item_Code, Item_Name, Req_Qty, pr.Prj_No, Prj_Name, Company_Name, convert(nvarchar(10), Delivery_Date, 23) Delivery_Date, pr.Remark
                            from Production_Req pr inner join Project p on pr.Prj_No = p.Prj_No
                                                    inner join Item_Master i on pr.Item_Code = i.Item_Code
                            where Req_Date between @fromReqDate and @toReqDate
                            and Delivery_Date between @fromDueDate and @toDueDate
                            and Deleted = 0";

                if (!string.IsNullOrWhiteSpace(list[4]))
                {
                    sql += " and pr.Item_Code = @Item_Code ";
                }
                if (!string.IsNullOrWhiteSpace(list[5]))
                {
                    sql += " and pr.Prj_No = @Prj_No";
                }

                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@fromReqDate", list[0]);
                    da.SelectCommand.Parameters.AddWithValue("@toReqDate", list[1]);
                    da.SelectCommand.Parameters.AddWithValue("@fromDueDate", list[2]);
                    da.SelectCommand.Parameters.AddWithValue("@toDueDate", list[3]);
                    if (!string.IsNullOrWhiteSpace(list[4]))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@Item_Code", list[4]);
                    }
                    if (!string.IsNullOrWhiteSpace(list[5]))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@Prj_No", list[5]);
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public bool Insert(OrderDTO data, string Ins_Emp)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_PrdReq_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Item_Code", data.Item_Code);
                    cmd.Parameters.AddWithValue("@Req_Qty", data.Req_Qty);
                    cmd.Parameters.AddWithValue("@Prj_No", data.Prj_No);
                    cmd.Parameters.AddWithValue("@Delivery_Date", data.Delivery_Date);
                    cmd.Parameters.AddWithValue("@Remark", data.Remark);
                    cmd.Parameters.AddWithValue("@Ins_Emp", Ins_Emp);

                    int a = cmd.ExecuteNonQuery(); 

                    if (a < 1)
                        return false;
                }

                return true;
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public string Update(OrderDTO data, string Ins_Emp)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_PrdReq_Update";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Item_Code", data.Item_Code);
                    cmd.Parameters.AddWithValue("@Req_Qty", data.Req_Qty);
                    cmd.Parameters.AddWithValue("@Prj_No", data.Prj_No);
                    cmd.Parameters.AddWithValue("@Delivery_Date", data.Delivery_Date);
                    cmd.Parameters.AddWithValue("@Remark", data.Remark);
                    cmd.Parameters.AddWithValue("@Up_Emp", Ins_Emp);
                    cmd.Parameters.AddWithValue("@Prd_Req_No", data.Prd_Req_No);

                    SqlParameter PO_CD = new SqlParameter("@PO_CD", SqlDbType.Int);
                    PO_CD.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(PO_CD);

                    cmd.ExecuteNonQuery();

                    if (Convert.ToInt32(PO_CD.Value) == 1)
                        return "이미 생성된 생산계획 또는 생산지시가 있어 생산요청을 수정할 수 없습니다.";
                }

                return "";
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return "생산요청 수정 중 오류가 발생했습니다. 다시 시도해 주세요.";
            }
        }

        public string Delete(string ordId, string Ins_Emp)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_PrdReq_Delete";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Prd_Req_No", ordId);
                    cmd.Parameters.AddWithValue("@Up_Emp", Ins_Emp);

                    SqlParameter PO_CD = new SqlParameter("@PO_CD", SqlDbType.Int);
                    PO_CD.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(PO_CD);

                    cmd.ExecuteNonQuery();

                    if (Convert.ToInt32(PO_CD.Value) == 1)
                        return "이미 생성된 생산계획 또는 생산지시가 있어 생산요청을 삭제할 수 없습니다.";
                }

                return "";
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return "생산요청 삭제 중 오류가 발생했습니다. 다시 시도해 주세요.";
            }
        }
    }
}
