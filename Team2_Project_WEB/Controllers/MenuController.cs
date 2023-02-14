using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using Team2_Project_WEB.Models;

namespace Team2_Project_WEB.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public PartialViewResult MenuList(string am)
        {
            string[] MenuName = WebConfigurationManager.AppSettings["menuList"].Split(',');
            string[] MenuAM = WebConfigurationManager.AppSettings["menuListAM"].Split(',');
            List<MenuVO> list = new List<MenuVO>();

            for (int i = 0; i < MenuName.Length; i++)
            {
                list.Add(new MenuVO { MenuName = MenuName[i], MenuAM = MenuAM[i] });
            }

            ViewBag.MenuList = list;
            ViewBag.SelectedAM = am;
            ViewBag.FAKit = WebConfigurationManager.AppSettings["FAKit"];

            return PartialView();
        }
    }
}