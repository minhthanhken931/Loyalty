using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection filed)
        {
            string error = "";
            string user = filed["email"];
            string password = filed["password"];
            if (user == "master@gmail.com" && password == "246810")
            {
                Session["UserAdmin"] = "master@gmail.com";
                return RedirectToAction("Index", "us");
            }
            else
            {
                if (user !="master@gmail.com" && password !="246810")
                {
                    error = "Email or Password is incorrect ! ";
                }
                if (user == "" && password == "")
                {
                    error = "Email or Password is not empty !";
                }    
                
            }
            ViewBag.StrError = "<div class = 'text-danger'>* " + error + "</div>";
            return View();
        }

        public ActionResult Logout()
        {
            Session["UserAdmin"] = "";
            return RedirectToAction("Index", "Home");
        }

        // Admin/Auth/Forgot_password
        public ActionResult Forgot_password()
        {
            ViewBag.StrError = "";
            return View();
        }

        [HttpPost]
        public ActionResult Forgot_password(FormCollection filed)
        {
            return View();
        }



    }
}