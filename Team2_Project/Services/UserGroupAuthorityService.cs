using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    public class UserGroupAuthorityService
    {
        public List<UserGroupAuthorityDTO> GetUserGroupCodeSearh()
        {
            UserGroupAuthorityDAO db = new UserGroupAuthorityDAO();
            List<UserGroupAuthorityDTO> list = db.GetUserGroupCodeSearh();
            db.Dispose();

            return list;
        }

        public bool FindSamePK(string userGrpCode)
        {
            UserGroupAuthorityDAO db = new UserGroupAuthorityDAO();
            bool result = db.FindSamePK(userGrpCode);
            db.Dispose();

            return result;
        }
        public bool InsertUserGroup(UserGroupAuthorityDTO uga)
        {
            UserGroupAuthorityDAO db = new UserGroupAuthorityDAO();
            bool list = db.InsertUserGroup(uga);
            db.Dispose();

            return list;
        }

        public bool UpdateUserGroup(UserGroupAuthorityDTO uga)
        {
            UserGroupAuthorityDAO db = new UserGroupAuthorityDAO();
            bool list = db.UpdateUserGroup(uga);
            db.Dispose();

            return list;
        }

        public int DeleteUserGroup(string userGrpCode)
        {
            UserGroupAuthorityDAO db = new UserGroupAuthorityDAO();
            int result = db.DeleteUserGroup(userGrpCode);
            db.Dispose();

            return result;
        }
    }
}
