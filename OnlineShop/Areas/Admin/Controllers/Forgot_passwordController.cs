using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class Forgot_passwordController : Controller
    {
        // GET: Admin/Forgot_password
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult register()
        {
            return RedirectToAction("Index", "Register");
        }
        public ActionResult login()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}