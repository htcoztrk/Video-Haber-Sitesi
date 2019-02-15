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
    public class KategoriController : Controller
    {
        BTU1Entities db = new BTU1Entities();
        // GET: Kategori
        public ActionResult Index(string id)
        {
            int xx = Int32.Parse(id);
            var model = new b3ViewModel()
            {
                kategoris = db.Kategoris.Find(xx),
                haber = db.Habers.Include(x=>x.Kategori).ToList(),
                uploads = db.Uploads.Include(x=>x.Haber).ToList()
            };

            return View("kategori_Index",model);
        }
    }
}