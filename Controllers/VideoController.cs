using B1.Models.EntityFramework;
using B1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Data.Entity;
namespace B1.Controllers
{
    public class VideoController : Controller
    {
        // GET: Video
        BTU1Entities db = new BTU1Entities();
        public ActionResult Index()
        {
            var model = new b1ViewModel()
            {
                uploads = db.Uploads.ToList(),
                habers = db.Habers.ToList()

                
            };

            return View(model);           
        }
        public ActionResult Play(int id)
        {
            var model = new b2ViewModel()
            {
                haber = db.Habers.Find(id),
                uye=new Uye(),
                upload=new Upload()
            };
            return View(model);
        }
        public ActionResult MostWatched()
        {
            var model = new b6ViewModel()
            {
                //video = db.Habers.Include(x => x.Uploads).OrderByDescending(x => x.tiklanma_s).ToList(),
                video=db.Habers.OrderByDescending(x=>x.tiklanma_s).ToList(),
                u = db.Uploads.OrderByDescending(x=>x.Haber.tiklanma_s).ToList()
            };
            
            return View(model);
        }
    }
}



