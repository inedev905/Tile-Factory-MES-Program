using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team2_Project_WEB.Models;
using Team2_Project_WEB.Models.DAO;

namespace Team2_Project_WEB.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userId, string password)
        {
            CommonDAO db = new CommonDAO();
            UserVO curUser = db.Login(userId, password);
            db.Dispose();

            if (curUser != null) //로그인 성공
            {
                //Session에 로그인 정보를 저장
                Session["UserInfo"] = curUser;
                Session["UserName"] = curUser.UserName;

                return RedirectToAction("Index", "Product");
            }
            else //로그인 실패
            {
                //계속 로그인 페이지에 남는다
                return RedirectToAction("Index", "Login"); //컨트롤러 생략 가능
            }
        }

        public ActionResult LogOut()
        {
            Session["UserInfo"] = null;
            Session.Clear();

            return RedirectToAction("Index");
        }
    }
}