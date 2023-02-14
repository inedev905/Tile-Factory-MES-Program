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
    public class PlanService
    {
        public DataTable GetPlanReq(string from, string to)
        {
            PlanDAO db = new PlanDAO();
            DataTable dt = db.GetPlanReq(from, to);

            return dt;
        }

        public bool InsertPlan(List<PlanDTO> plans)
        {
            PlanDAO db = new PlanDAO();
            bool result = db.InsertPlan(plans);

            return result;
        }
    }
}
