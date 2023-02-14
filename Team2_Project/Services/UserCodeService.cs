using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    public class UserCodeService
    {
        public List<UserCodeDTO> GetUserCode()
        {
            UserCodeDAO db = new UserCodeDAO();
            List<UserCodeDTO> list = db.GetUserCode();

            return list;
        }

        public bool CheckPK(string maCode, string miCode)
        {
            UserCodeDAO db = new UserCodeDAO();
            bool result = db.CheckPK(maCode, miCode);

            return result;
        }

        public bool InsertUserCode(UserCodeDTO code)
        {
            UserCodeDAO db = new UserCodeDAO();
            bool result = db.InsertUserCode(code);

            return result;
        }

        public bool UpdateUserCode(UserCodeDTO code)
        {
            UserCodeDAO db = new UserCodeDAO();
            bool result = db.UpdateUserCode(code);

            return result;
        }

        public int DeleteUserCode(string maCode, string miCode)
        {
            UserCodeDAO db = new UserCodeDAO();
            int result = db.DeleteUserCode(maCode, miCode);

            return result;
        }
    }
}
