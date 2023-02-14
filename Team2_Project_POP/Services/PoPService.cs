using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project_POP.Services
{
    public class PoPService
    {
        public List<WorkCenterDTO> GetWorkCenterInfo()
        {
            WorkCenterDAO db = new WorkCenterDAO();
            List<WorkCenterDTO> list = db.GetWorkCenterInfo();
            db.Dispose();

            return list;
        }
    }
}
