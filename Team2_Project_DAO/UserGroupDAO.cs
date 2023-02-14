using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Team2_Project_DTO;
using System.Data;

namespace Team2_Project_DAO
{
    public class UserGroupDAO : IDisposable
    {
        string connStr = null;
        SqlConnection conn;

        public UserGroupDAO()
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

        public List<CodeDTO> GetUserGroupCode()
        {

            string sql = "select UserGroup_Code Code, UserGroup_Name Name from UserGroup_Master where Use_YN = 'Y'";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                List<CodeDTO> list = Helper.DataReaderMapToList<CodeDTO>(cmd.ExecuteReader());
                return list;
            }
        }
    }
}
