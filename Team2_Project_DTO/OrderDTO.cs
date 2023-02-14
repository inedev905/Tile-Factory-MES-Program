using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class OrderDTO
    {
        public string Prd_Req_No { get; set; }
        public string Req_Date { get; set; }
        public string Req_Seq { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public int Req_Qty { get; set; }
        public string Prj_No { get; set; }
        public string Delivery_Date { get; set; }
        public int Plan_Qty { get; set; }
        public string Plan_YN { get; set; }
        public string Prd_Progress_Status { get; set; }
        public string Remark { get; set; }
    }
}
