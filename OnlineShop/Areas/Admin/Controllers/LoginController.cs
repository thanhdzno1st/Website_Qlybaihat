using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OnlineShop.Areas.Admin.Code;
using OnlineShop.Areas.Admin.Models;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
          //  var result = new AccountModel().login(model.UserName,model.Password);
            if (Membership.ValidateUser(model.UserName, model.Password) && ModelState.IsValid)
            {
                //SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                Session["UserName"] = model.UserName;
                return RedirectToAction("Index","Home");
            }else
            {
                ModelState.AddModelError("","Tên đăng nhập hoặc mật khẩu không đúng");
            }    
            return View(model);
        }
        public ActionResult Logout()
        {
            Session["UserName"] = null;
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult Forgotpassword()
        {
            return RedirectToAction("Index", "Forgot_password");
        }
        public ActionResult register()
        {
            return RedirectToAction("Index", "Register");
        }
    }
}