using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class SysMaCodeDTO
    {
        //Sys_Ma_Code, Sys_Ma_Name, Remark, Up_Date, Up_Emp, Ins_Date, Ins_Emp
        public string Sys_Ma_Code { get; set; }
        public string Sys_Ma_Name { get; set; }
        public string Up_Date { get; set; }
        public string Up_Emp { get; set; }
        public string Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
    }

    public class SysMiCodeDTO
    {
        //Sys_Ma_Code, Sys_Mi_Code, Sys_Mi_Name, Sort_Index, Remark, Use_YN, Up_Date, Up_Emp, Ins_Date, Ins_Emp
        //public string Sys_Ma_Code { get; set; }
        public string Sys_Mi_Code { get; set; }
        public string Sys_Mi_Name { get; set; }
        public int Sort_Index { get; set; }
        public string Use_YN { get; set; }
        public string Remark { get; set; }
        public string Up_Date { get; set; }
        public string Up_Emp { get; set; }
        public string Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
    }
}
