using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simpleChat.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Chat()
        {
            if(myUser.isLogged())
            return View();
            else
            {
                return Redirect("~/Account/Login.aspx");
            }
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public void Logout()
        {
            myUser.logOut();
            Response.Redirect("~");
        }
        

    }
}