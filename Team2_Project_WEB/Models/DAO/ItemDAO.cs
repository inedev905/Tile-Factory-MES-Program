using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Team2_Project_WEB.Models;

namespace Team2_Project_WEB.Models.DAO
{
    public class ItemDAO : IDisposable
    {
        SqlConnection conn = null;

        public ItemDAO()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        public void GetItemList()
        {
            //string sql = @"select user_id, user_pwd, user_name, auth_name
            //                from Userinfo u inner join Authority a on u.auth_id = a.auth_id
            //                where user_id = @uid and user_pwd = @pwd";

            //using (SqlCommand cmd = new SqlCommand(sql, conn))
            //{
            //    cmd.Parameters.AddWithValue("@uid", uid);
            //    cmd.Parameters.AddWithValue("@pwd", pwd);

            //    SqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        return new UserVO
            //        {
            //            UserId = reader["user_id"].ToString(),
            //            UserPwd = reader["user_pwd"].ToString(),
            //            UserName = reader["user_name"].ToString(),
            //            AuthName = reader["auth_name"].ToString()
            //        };
            //    }
            //    else
            //        return null;
            //}
        }
    }
}