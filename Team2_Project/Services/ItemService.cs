using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class ItemService
    {
        public List<ItemDTO> GetItemSearch(ItemDTO item)
        {
            ItemDAO db = new ItemDAO();
            List<ItemDTO> list = db.GetItemSearch(item);
            db.Dispose();
            return list;
        }

        public bool GetItemAdd(ItemDTO item)
        {
            ItemDAO db = new ItemDAO();
            bool result = db.GetItemAdd(item);
            db.Dispose();
            return result;
        }

        public bool GetItemUpdate(ItemDTO item)
        {
            ItemDAO db = new ItemDAO();
            bool result = db.GetItemUpdate(item);
            db.Dispose();
            return result;
        }

        public bool CheckPK(string ItemCode)
        {
            ItemDAO db = new ItemDAO();
            bool result = db.CheckPK(ItemCode);
            db.Dispose();
            return result;
        }

        public int DeleteItemCode(string Code)
        {
            ItemDAO db = new ItemDAO();
            int result = db.DeleteItemCode(Code);
            db.Dispose();
            return result;
        }

        public List<ItemDTO> GetItemCodeName()
        {
            ItemDAO db = new ItemDAO();
            List<ItemDTO> list = db.GetItemCodeName();
            db.Dispose();

            return list;
        }

        public List<CodeDTO> GetCode(string txt)
        {
            ItemDAO db = new ItemDAO();
            List<CodeDTO> list = db.GetCode(txt);
            db.Dispose();
            return list;
        }

        #region 미사용
        public List<ItemDTO> GetCurItem(string item)
        {
            ItemDAO db = new ItemDAO();
            List<ItemDTO> list = db.GetCurItem(item);
            db.Dispose();
            return list;
        }
        #endregion
    }
}
