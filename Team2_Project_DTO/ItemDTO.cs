using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class ItemDTO
	{
		public string Item_Code { get; set; }
		public string Item_Name { get; set; }
		public string Item_Type { get; set; }
		public string Item_Spec { get; set; }
		public string Remark { get; set; }	 
		public string Use_YN { get; set; }	 
		public string Ins_Date { get; set; }
		public string Ins_Emp { get; set; }	 
		public string Up_Date { get; set; }	 
		public string Up_Emp { get; set; }   

		// === 미사용 ===
		//public string Item_Name_Eng { get; set; }	
		//public string Item_Unit { get; set; }	 
		//public string Level_1 { get; set; }	 
		//public string Level_2 { get; set; }	 
		//public decimal PrdQty_Per_Hour { get; set; }	 
		//public decimal PrdQty_Per_Batch { get; set; }	 
	}
}