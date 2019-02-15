using B1.Models.Deneme;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using HtmlAgilityPack;
using B1.ViewModel;
using B1.Models.EntityFramework;
using System.Data.Entity;
namespace B1.Controllers
{
    public class AnasayfaController : Controller
    {
        BTU1Entities db = new BTU1Entities();
        // GET: Anasayfa
        public ActionResult IndexVeriCekme(Films model,b4ViewModel m)
        {
            var veri = new WebClient().DownloadString("C:/Users/Hp/source/repos/B1/B1/Content/CSS/css1.css");
            var mode = new Films()
            {
                //url = new Uri("https://www.sinemalar.com/sinemahaberleri"),
                url = new Uri("https://www.webtekno.com/haber"),
                html = "",
                xpath = ""
            };




            try
            {
                //model.url = new Uri("https://www.sinemalar.com//sinemahaberleri");
                mode.url = new Uri("https://shiftdelete.net/teknoloji-haberleri");
            }
            catch (UriFormatException)
            {

            }
            catch (ArgumentNullException)
            {

            }
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                mode.html = client.DownloadString(mode.url);
            }
            catch (WebException){ }

           
            try
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(mode.html);
                //mode.xpath = "//*[@id='container']/div[2]/div[5]/div[" + 1 + "]/div/h3/a";
                //mode.xpath= "/html/body/div[2]/section/div/div[4]/ul/li[2]/div[2]/a/em";
                mode.xpath = "/html/body/div[2]/section/div/div[4]/ul/li[2]/div[1]/a/img";
                mode.sonuc = doc.DocumentNode.SelectSingleNode(mode.xpath).InnerText;
            }
            catch (NullReferenceException)
            {

            }
            
            return View(mode);
        }



        public ActionResult Video()
        {

            var model = new b1ViewModel()
            {
                uploads = db.Uploads.ToList(),
                habers = db.Habers.ToList()
                //habers = db.Habers.Include(x => x.Upload).ToList()


            };

            //var model = db.Habers.ToList();
            //var model = db.Uploads.Include(x=>x.Haber).ToList();
            return View(model);

        }
       
    }
    
}