using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class EmployeeService
    {
        public DataTable GetEmployeeList()
        {
            EmployeeDAO db = new EmployeeDAO();
            DataTable dt = db.GetEmployeeList();
            db.Dispose();

            return dt;
        }

        public EmployeeDTO GetLoginEmp(string userID, string userPw)
        {
            EmployeeDAO db = new EmployeeDAO();
            EmployeeDTO empInfo = db.GetLoginEmp(userID, userPw);
            db.Dispose();

            return empInfo;
        }

        public bool Insert(EmployeeDTO data, string Ins_Emp)
        {
            EmployeeDAO db = new EmployeeDAO();
            bool result = db.Insert(data, Ins_Emp);
            db.Dispose();

            return result;
        }

        public bool Update(EmployeeDTO data, string Ins_Emp)
        {
            EmployeeDAO db = new EmployeeDAO();
            bool result = db.Update(data, Ins_Emp);
            db.Dispose();

            return result;
        }

        public string Delete(string empID)
        {
            EmployeeDAO db = new EmployeeDAO();
            string msg = db.Delete(empID);
            db.Dispose();

            return msg;
        }

        public List<CodeDTO> GetUserGroupCode()
        {
            UserGroupDAO db = new UserGroupDAO();
            List<CodeDTO> list = db.GetUserGroupCode();
            db.Dispose();

            return list;
        }

        public bool CheckUserID(string id)
        {
            EmployeeDAO db = new EmployeeDAO();
            bool result = db.CheckUserID(id);
            db.Dispose();

            return result;
        }

        public bool CheckUserpW(string id, string pw)
        {
            EmployeeDAO db = new EmployeeDAO();
            bool result = db.CheckUserpW(id, pw);
            db.Dispose();

            return result;           
        }

        public bool UpdatePW(string id, string pw)
        {
            EmployeeDAO db = new EmployeeDAO();
            bool result = db.UpdatePW(id, pw);
            db.Dispose();

            return result;
        }
    }
}
