using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    
    public class DefCodeService
    {

        public List<DefCodeDTO> GetDefCode(bool isMaCode)
        {
            DefCodeDAO db = new DefCodeDAO();
            List<DefCodeDTO> list = db.GetDefCode(isMaCode);

            return list;
        }

        public bool CheckPK(bool isMaCode, string code)
        {
            DefCodeDAO db = new DefCodeDAO();
            bool result = db.CheckPK(isMaCode, code);

            return result;
        }

        public bool InsertDefCode(bool isMaCode, DefCodeDTO code)
        {
            DefCodeDAO db = new DefCodeDAO();
            bool result = db.InsertDefCode(isMaCode, code);

            return result;
        }

        public bool UpdateDefCode(bool isMaCode, DefCodeDTO code)
        {
            DefCodeDAO db = new DefCodeDAO();
            bool result = db.UpdateDefCode(isMaCode, code);

            return result;
        }

        public int DeleteDefCode(bool isMaCode, string code)
        {
            DefCodeDAO db = new DefCodeDAO();
            int result = db.DeleteDefCode(isMaCode, code);

            return result;
        }


    }
}
