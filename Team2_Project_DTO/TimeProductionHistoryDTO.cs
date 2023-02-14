using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class TimeProductionHistoryDTO
    {
        //작업지시목록 : 작업지시상태, 작업지시번호, 작업지시일자, 작업지시수량, 계획수량단위, 품목코드, 품목명, 작업장, 생산일자, 생산시작, 생산종료, 투입, 산출, 생산수량, 불량수량, 시간대
        public string Wo_Status { get; set; }       //작업지시상태	
        public string WorkOrderNo { get; set; }     //작업지시번호	
        public int Start_Hour { get; set; }         //시작시간대		
        public int In_Qty_Main { get; set; }        //투입수량Main	
        public int Out_Qty_Main { get; set; }       //산출수량Main	
        public int Plan_Qty_Box { get; set; }       //계획수량		
        public string Plan_Unit { get; set; }       //계획수량단위	
        public string Prd_Date { get; set; }        //생산일자      //date		
        public string Prd_StartTime { get; set; }   //작업시작시간	//datetime
        public string Prd_EndTime { get; set; }     //작업종료시간	//datetime
        public int Prd_Qty { get; set; }            //생산수량		
        public string Ins_Date { get; set; }        //최초입력일자	//datetime
        public int Def_Qty { get; set; }            //불량수량		
        public string Item_Code { get; set; }       //품목코드		
        public string Item_Name { get; set; }       //품목명		
        public string Process_Code { get; set; }    //공정코드
        public string Process_Name { get; set; }     //공정명
        public string Wc_Code { get; set; }         //작업장코드
        public string Wc_Name { get; set; }         //작업장명



    }
}
