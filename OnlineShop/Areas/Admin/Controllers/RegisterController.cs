using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Admin/Register
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            return RedirectToAction("index","Login");
        }
        public ActionResult forgotpassword()
        {
            return RedirectToAction("index", "Forgot_password");
        }
    }
}