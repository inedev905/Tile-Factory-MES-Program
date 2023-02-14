using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
	public class NopHistoryDTO
	{
		/*
		Nop_Seq, Nop_Date, Nop_HappenTime, Nop_CancelTime, Nop_Mi_Code, Nop_Time, Wc_Code 
	  , Wc_Name, Wc_Group, Process_Code
	  , Process_Name
	  , Nop_Mi_Name, Nop_Ma_Code, Regular_Type, Nop_type, Use_YN
	  , Nop_Ma_Name
		*/

		public Int64 Nop_Seq { get; set; }			 //비가동 순번
		public string Nop_Date { get; set; }		 //비가동발생일자
		public string Nop_HappenTime { get; set; }   //비가동발생일시
		public string Nop_CancelTime { get; set; }   //비가동해제일시
		public string Nop_Mi_Code { get; set; }		 //비가동상세분류코드
		public decimal Nop_Time { get; set; }		 //비가동시간
		public string Wc_Code { get; set; }			 //작업장코드
		//public string Nop_Type { get; set; }
		//public string Remark { get; set; }


		public string Wc_Name { get; set; }		  //작업장명
		public string Wc_Group { get; set; }	  //작업장그룹
		public string Process_Code { get; set; }  //공정코드


		public string Process_Name { get; set; }  //공정명


		public string Nop_Mi_Name { get; set; }  //비가동상세분류명
		public string Nop_Ma_Code { get; set; }  //비가동대분류코드
		public string Nop_type { get; set; }	 //비가동유형
		//public string Use_YN { get; set; }


		public string Nop_Ma_Name { get; set; }  //비가동대분류명


		//
		public string DateFrom { get; set; }
		public string DateTo { get; set; }

		#region // --- 추가, 수정 --- //
		public string Ins_Date { get; set; } //
		public string Ins_Emp { get; set; }  //
		public string Up_Date { get; set; }  //
		public string Up_Emp { get; set; }   //
		#endregion

	}
}