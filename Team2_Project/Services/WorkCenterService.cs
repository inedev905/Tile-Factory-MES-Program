using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    public class WorkCenterService
    {
        public List<WorkCenterDTO> GetWorkCenterInfo()
        {
            WorkCenterDAO db = new WorkCenterDAO();
            List<WorkCenterDTO> list = db.GetWorkCenterInfo();
            db.Dispose();

            return list;
        }

        public bool FindSamePK(string wcCode)
        {
            WorkCenterDAO db = new WorkCenterDAO();
            bool result = db.FindSamePK(wcCode);
            db.Dispose();

            return result;
        }

        public bool InsertWorkCenter(WorkCenterDTO wc)
        {
            WorkCenterDAO db = new WorkCenterDAO();
            bool result = db.InsertWorkCenter(wc);
            db.Dispose();

            return result;
        }

        public bool UpdateWorkCenter(WorkCenterDTO wc)
        {
            WorkCenterDAO db = new WorkCenterDAO();
            bool result = db.UpdateWorkCenter(wc);
            db.Dispose();

            return result;
        }

        public int DeleteWorkCenter(string wcCode)
        {
            WorkCenterDAO db = new WorkCenterDAO();
            int result = db.DeleteWorkCenter(wcCode);
            db.Dispose();

            return result;
        }

        public List<WorkCenterDTO> GetWcCodeName()
        {
            WorkCenterDAO db = new WorkCenterDAO();
            List<WorkCenterDTO> list = db.GetWcCodeName();
            db.Dispose();

            return list;
        }
    }
}
