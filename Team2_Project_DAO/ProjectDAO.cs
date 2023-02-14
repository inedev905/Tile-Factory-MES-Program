using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Team2_Project_DTO;


namespace Team2_Project_DAO 
{
    public class ProjectDAO : IDisposable
    {
        string connStr = null;
        SqlConnection conn;

        public ProjectDAO()
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

        public List<ProjectDTO> GetProjectList()
        {
            string sql = "select Prj_No, Company_Name, Prj_Name from Project";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                List<ProjectDTO> list = Helper.DataReaderMapToList<ProjectDTO>(cmd.ExecuteReader());

                return list;
            }
        }

    }
}
