using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class OrderService
    {
        public DataTable GetOrderList(string[] list)
        {
            OrderDAO db = new OrderDAO();
            DataTable dt = db.GetOrderList(list);
            db.Dispose();

            return dt;
        }

        public bool Insert(OrderDTO data, string Ins_Emp)
        {
            OrderDAO db = new OrderDAO();
            bool result = db.Insert(data, Ins_Emp);
            db.Dispose();

            return result;
        }

        public string Update(OrderDTO data, string Ins_Emp)
        {
            OrderDAO db = new OrderDAO();
            string msg = db.Update(data, Ins_Emp);
            db.Dispose();

            return msg;
        }

        public string Delete(string ordId, string empId)
        {
            OrderDAO db = new OrderDAO();
            string msg = db.Delete(ordId, empId);
            db.Dispose();

            return msg;
        }

        public List<ItemDTO> GetItemCodeName()
        {
            ItemDAO db = new ItemDAO();
            List<ItemDTO> list = db.GetItemCodeName();
            db.Dispose();

            return list;
        }

        public List<ProjectDTO> GetProjectList()
        {
            ProjectDAO db = new ProjectDAO();
            List<ProjectDTO> list = db.GetProjectList();
            db.Dispose();

            return list;
        }
    }
}
