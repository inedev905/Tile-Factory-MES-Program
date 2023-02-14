using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class EmployeeDTO
    {//u.User_ID, User_Name, User_Type, dmas.DashboardItem, dmas.Title, u.Use_YN
        public string User_ID { get; set; } //사용자 ID
        public string User_Name { get; set; } //사용자 이름
        public string User_Type { get; set; } //사용자 권한
        public string UserGroup_Code { get; set; } //권한그룹코드
        public string UserGroup_Name { get; set; } //권한그룹명
        public string Use_YN { get; set; } //퇴사여부
        public string UserPW { get; set; } //비밀번호
    }
}
