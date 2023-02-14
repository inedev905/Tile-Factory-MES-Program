using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class PlanDTO
    {
		public string Prd_Plan_No { get; set; }  //
		public string Plan_Month { get; set; }   //
		public int Prd_Order { get; set; }   //
		public string Item_Code { get; set; }    //
		public int Plan_Qty { get; set; }    //
		public string Prd_Plan_Status { get; set; }  //
		public int Plan_Rest_Qty { get; set; }   //
		public string Wc_Code { get; set; }  //
		public string Wc_Name { get; set; }  //
		public string Remark { get; set; }   //
		public DateTime Ins_Date { get; set; }   //
		public string Ins_Emp { get; set; }  //
		public DateTime Up_Date { get; set; }    //
		public string Up_Emp { get; set; }   //

		public string Prd_Req_No { get; set; }

	}
}
