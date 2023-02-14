using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class NopCodeService
    {
        public List<NopMaCodeDTO> GetNopMaSearch(NopMaCodeDTO item)
        {
            NopCodeDAO db = new NopCodeDAO();
            List<NopMaCodeDTO> list = db.GetNopMaSearch(item);
            db.Dispose();
            return list;
        }

        public bool NopMaCodeAdd(NopMaCodeDTO item)
        {
            NopCodeDAO db = new NopCodeDAO();
            bool result = db.NopMaCodeAdd(item);
            db.Dispose();
            return result;
        }


        public bool NopMaCodeUpdate(NopMaCodeDTO item)
        {
            NopCodeDAO db = new NopCodeDAO();
            bool result = db.NopMaCodeUpdate(item);
            db.Dispose();
            return result;
        }

        public bool CheckPK(string ItemCode)
        {
            NopCodeDAO db = new NopCodeDAO();
            bool result = db.CheckPK(ItemCode);
            db.Dispose();
            return result;
        }

        public bool CheckMiPK(string ItemCode)
        {
            NopCodeDAO db = new NopCodeDAO();
            bool result = db.CheckMiPK(ItemCode);
            db.Dispose();
            return result;
        }

        public int DeleteMaCode(string Code)
        {
            NopCodeDAO db = new NopCodeDAO();
            int result = db.DeleteMaCode(Code);
            db.Dispose();
            return result;
        }

        public int DeleteMiCode(string Code)
        {
            NopCodeDAO db = new NopCodeDAO();
            int result = db.DeleteMiCode(Code);
            db.Dispose();
            return result;
        }

        public List<NopMiCodeDTO> GetNopMiSearch(NopMiCodeDTO item)
        {
            NopCodeDAO db = new NopCodeDAO();
            List<NopMiCodeDTO> list = db.GetNopMiSearch(item);
            db.Dispose();
            return list;
        }

        public bool NopMiCodeAdd(NopMiCodeDTO item)
        {
            NopCodeDAO db = new NopCodeDAO();
            bool result = db.NopMiCodeAdd(item);
            db.Dispose();
            return result;
        }


        public bool NopMiCodeUpdate(NopMiCodeDTO item)
        {
            NopCodeDAO db = new NopCodeDAO();
            bool result = db.NopMiCodeUpdate(item);
            db.Dispose();
            return result;
        }

        //비가동이력조회
        public List<NopHistoryDTO> GetNopMiSearch(NopHistoryDTO item)
        {
            NopHistoryDAO db = new NopHistoryDAO();
            List<NopHistoryDTO> list = db.GetNopMiSearch(item);
            db.Dispose();
            return list;
        }

        #region 미사용
        public List<NopMaCodeDTO> GetMaCurItem(string item)
        {
            NopCodeDAO db = new NopCodeDAO();
            List<NopMaCodeDTO> list = db.GetMaCurItem(item);
            db.Dispose();
            return list;
        }
        #endregion
    }
}
