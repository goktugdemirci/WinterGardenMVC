using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinterGardenMVC.Helpers;
using WinterGardenMVC.Models;
using WinterGardenMVC.ViewModels;

namespace WinterGardenMVC.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private WinterContext db = new WinterContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                int number = db.Admin.Count(s => (s.Email == model.Credential && s.Password == model.Password) ||
                                                 (s.Username == model.Credential && s.Password == model.Password));
                if (number > 0)
                {
                    Models.Admin a = db.Admin.First(s => (s.Email == model.Credential && s.Password == model.Password) ||
                                                   (s.Username == model.Credential && s.Password == model.Password));
                    Session["admin"] = a;
                    return RedirectToAction("Index", "Anasayfa");
                }
                else
                {
                    TempData["message"] = new ToastMessage()
                    {
                        Header = "Failed",
                        Body = "User Not Found",
                        Type = ToastType.error
                    };
                }
            }
            else
            {
                string message = "";
                foreach (ModelState item in ModelState.Values)
                {
                    if (item.Errors.Count!=0)
                    {
                        message += item.Errors[0].ErrorMessage + "\n";
                    }
                }
                TempData["message"] = new ToastMessage()
                {
                    Header = "Failed",
                    Body = message,
                    Type = ToastType.error
                };
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult RecoverPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RecoverPassword(RecoverViewModel model)
        {
            return View();
        }
    }
}
