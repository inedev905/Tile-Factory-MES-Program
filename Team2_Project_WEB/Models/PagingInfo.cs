using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team2_Project_WEB.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; } //총 데이터 건수
        public int ItemsPerPage { get; set; } //한 페이지당 목록건수
        public int CurrentPage { get; set; } //현재 페이지번호

        public int TotalPages //전체 페이지 수
        {
            get
            {
                return (int)Math.Ceiling((double)TotalItems / ItemsPerPage);
            }
        }
    }
}