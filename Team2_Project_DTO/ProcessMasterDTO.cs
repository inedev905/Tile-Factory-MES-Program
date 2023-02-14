using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_Project_DTO
{
    public class ProcessMasterDTO
    {
        public string Process_Code { get; set; }
        public string Process_Name { get; set; }
        public string Process_Group { get; set; }
        public string Use_YN { get; set; }
        public string Remark { get; set; }
        public DateTime Up_Date { get; set; }   //
        public string Up_Emp { get; set; }  //
    }
}
