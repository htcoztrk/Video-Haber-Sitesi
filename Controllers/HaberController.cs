using B1.Models.EntityFramework;
using B1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace B1.Controllers
{
    public class HaberController : Controller
    {
        BTU1Entities db = new BTU1Entities();
        // GET: Controller
        public ActionResult Index()
        {
            var model = db.Haber2.OrderByDescending(x=>x.hbr_trh).ToList();
             return View("haber_Index",model);
        }
        public ActionResult Detay(int id)
        {
            var model = db.Haber2.Find(id);

            return View(model);
        }
        public ActionResult MostReaded()
        {
            var haber = from s in db.Haber2
                           select s;
            haber = haber.OrderByDescending(s => s.tiklanma_s);
            return View(haber);
        }
        public ActionResult MostShared()
        {
            var haber = from s in db.Haber2
                        select s;
            haber = haber.OrderByDescending(s => s.paylasim_s);
            return View(haber);
        }
    }
}