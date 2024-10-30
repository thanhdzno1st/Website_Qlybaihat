using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Authorize]

    public class ArtistController : Controller
    {
        // GET: Admin/Tables
        public ActionResult Index()
        {
            return View();
        }
    }
}