using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Authorize]

    public class CategoryManagementController : Controller
    {
        // GET: Admin/Ultilities_other
        public ActionResult Index()
        {
            return View();
        }
    }
}