using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        Context c = new Context();
        public ActionResult Index()
        {

            var degerler = c.Blogs.Take(3).ToList();
            return View(degerler);
        }
       
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()  //fotografları ayrı bir yer olusması ıcın  left 2 foto için 
        {
            var degerler = c.Blogs.OrderByDescending(x => x.BlogId ).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2() //parcalı partial rihgt foto için 
        {
            var degerler = c.Blogs.Where(x => x.BlogId == 1).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()  //favori yerlerin sol kısmı için 
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()  //favori yerlerin sağ kısmı için 
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x=>x.BlogId).ToList();
            return PartialView(deger);
        }

    }
}