using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2_Project_DAO;
using Team2_Project_DTO;

namespace Team2_Project.Services
{
    class AnalysisService
    {

        public List<TimeProductionHistoryDTO> GetWorkOrder(string from, string to)
        {
            AnalysisDAO db = new AnalysisDAO();
            List<TimeProductionHistoryDTO> list = db.GetWorkOrder(from, to);
            db.Dispose();
            return list;
        }

        public List<TimeProductionHistoryDTO> GetTimeProductionHistory()
        {
            AnalysisDAO db = new AnalysisDAO();
            List<TimeProductionHistoryDTO> list = db.GetTimeProductionHistory();
            db.Dispose();
            return list;
        }
    }
}
