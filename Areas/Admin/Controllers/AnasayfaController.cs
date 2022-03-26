using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinterGardenMVC.Filters;

namespace WinterGardenMVC.Areas.Admin.Controllers
{
    [AdminAuthenticationFilter]
    public class AnasayfaController : Controller
    {
        // GET: Admin/Anasayfa
        public ActionResult Index()
        {
            return View();
        }
    }
}