using B1.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace B1.Controllers
{
    public class SecurityController : Controller
    {
        BTU1Entities db = new BTU1Entities();
        // GET: Security
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Uye uye)
        {
            var u = db.Uyes.FirstOrDefault(x => x.uye_password == uye.uye_password && x.uye_name == uye.uye_name);
            if (u != null)
            {
                FormsAuthentication.SetAuthCookie(uye.uye_name, false);
                return RedirectToAction("Video", "Anasayfa");
            }
            else
            {
                ViewBag.Mesaj = "Invalid name or password";
                return View();
            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        [HttpPost]
        public ActionResult SignIn(Uye uye)
        {
            db.Uyes.Add(uye);
            db.SaveChanges();
            return RedirectToAction("Video", "Anasayfa");
        }
        [HttpGet]
        public ActionResult SignIn()
        {
           
            return View();
        }
    }
}