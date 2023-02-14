using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team2_Project_WEB.Models
{
    public class ItemVO
    {//제품명, 제품코드, 거래비율, 전월 주문량, 전월 주문고객수, 당월 주문량, 당월 주문고객수
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Ratio { get; set; }
        public int Order_p { get; set; }
        public int Customer_p { get; set; }
        public int Order_c { get; set; }
        public int Customer_c { get; set; }
    }
}