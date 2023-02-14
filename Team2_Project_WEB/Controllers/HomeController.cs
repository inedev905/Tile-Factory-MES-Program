using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using Team2_Project_WEB.Models;

namespace Team2_Project_WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Item() //제품별 판매량 조회
        {
            List<ItemVO> list = new List<ItemVO>();
            list.Add(new ItemVO { Name = "제품1", Code = "Prod1", Ratio = 100, Order_p = 10, Customer_p = 2, Order_c = 20, Customer_c = 4 });

            return View(list);
        }

        public ActionResult ProdO() //생산지시 실적 조회
        {
            List<ItemVO> list = new List<ItemVO>();
            list.Add(new ItemVO { Name = "제품1", Code = "Prod1", Ratio = 100, Order_p = 10, Customer_p = 2, Order_c = 20, Customer_c = 4 });

            return View(list);
        }

        public ActionResult ProdT() //시간당 생산량 조회
        {
            List<ItemVO> list = new List<ItemVO>();
            list.Add(new ItemVO { Name = "제품1", Code = "Prod1", Ratio = 100, Order_p = 10, Customer_p = 2, Order_c = 20, Customer_c = 4 });

            return View(list);
        }

        public ActionResult Defect() //불량 이력 조회
        {
            List<ItemVO> list = new List<ItemVO>();
            list.Add(new ItemVO { Name = "제품1", Code = "Prod1", Ratio = 100, Order_p = 10, Customer_p = 2, Order_c = 20, Customer_c = 4 });

            return View(list);
        }

        public ActionResult WPlace() //작업장 가동현황 조회
        {
            List<ItemVO> list = new List<ItemVO>();
            list.Add(new ItemVO { Name = "제품1", Code = "Prod1", Ratio = 100, Order_p = 10, Customer_p = 2, Order_c = 20, Customer_c = 4 });

            return View(list);
        }

        public ActionResult Schedule() //월별 스케쥴 조회
        {
            List<ItemVO> list = new List<ItemVO>();
            list.Add(new ItemVO { Name = "제품1", Code = "Prod1", Ratio = 100, Order_p = 10, Customer_p = 2, Order_c = 20, Customer_c = 4 });

            return View(list);
        }
    }
}