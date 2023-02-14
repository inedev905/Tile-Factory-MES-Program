using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class UserGroupAuthorityDTO
    {
        public string UserGroup_Code { get; set; }  //사용자 그룹코드 
        public string UserGroup_Name { get; set; }  //사용자 그룹명
        public string Admin          { get; set; }  //Admin 여부
        public string Use_YN         { get; set; }  //사용여부 
        public string Up_Date        { get; set; }  //최초 수정날짜 
        public string Up_Emp         { get; set; }  //최초수정자
        public string Ins_Date       { get; set; }  //최초등록날짜
        public string Ins_Emp        { get; set; }  //최초등록자 
        public string User_ID        { get; set; }  //사용자 ID

    }
}
