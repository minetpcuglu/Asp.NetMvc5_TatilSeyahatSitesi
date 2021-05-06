using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Controllers
{

    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(c => c.BlogId).Take(3).ToList();  //ilk 3 blogu al 
            by.Deger4 = c.Yorumlars.OrderByDescending(c => c.YorumId).Take(1).ToList();
            //var bloglar = c.Blogs.ToList();
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {

            //var blogbul = c.Blogs.Where(x => x.BlogId == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.BlogId == id).ToList(); //blogları listeleme 
            by.Deger2 = c.Yorumlars.Where(x => x.BlogId == id).ToList();  //yorumları listeleme
            return View(by);
        }

        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;  //viewbag ile deger ataması
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar b)
        {
            c.Yorumlars.Add(b);  //b dem gelen degeri blogun içine ekle 
            c.SaveChanges();
            return PartialView();
        }
    }
}