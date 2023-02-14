using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class WorkCenterDTO
    {
        public string Wc_Code        { get; set; }   //작업장 코드 PK
        public string Wc_Name        { get; set; }   //작업장 명 
        public string Wc_Group       { get; set; }   //작업장 그룹
        public string Wc_Group_Name  { get; set; }   //작업장 그룹 명
        public string Process_Code   { get; set; }   //공정 코드   FK
        public string Process_Name   { get; set; }   //공정 명
        public string Remark         { get; set; }   //비고
        public string Use_YN         { get; set; }   //사용유무
        public string Wo_Status      { get; set; }   //작업지시 상태 코드 (공통코드)
        public string Wo_Status_Name { get; set; }   //작업지시 상태 이름 (공통코드)
        public string Wc_Status      { get; set; }   //작업장 가동,비가동 여부 상태
        public string Pallet_YN      { get; set; }   //팔렛 생성 유무
        public string Ins_Date       { get; set; }   //최초등록날짜
        public string Up_Date        { get; set; }   //최종수정날짜
        public string Ins_Emp        { get; set; }   //최초 등록자
        public string Up_Emp         { get; set; }   //최종 수정자


        //사용 안함
        //public string Auto_Wo_YN { get; set; }   //자동작업지시 여부
        //public string Auto_Start_YN { get; set; }   //자동작업지시 시작여부
        //public string Last_Cnt_Time { get; set; }   //최종실적 처리시간
        //public string Prd_Unit { get; set; }   //실적 단위
    }
}
