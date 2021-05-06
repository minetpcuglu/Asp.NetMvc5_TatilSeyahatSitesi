using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.Blogs.ToList();
            return View(deger);
        }
        //public ActionResult

        [HttpGet]
        public ActionResult YeniBlogEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlogEkle(Blog p)
        {
             c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var deger = c.Blogs.Find(id);
            c.Blogs.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult BlogGuncelle(int id)  //bu blog guncelleme sayfasını getirir
        {
            var deger = c.Blogs.Find(id);
            return View("BlogGuncelle", deger); //degerden gelen sayfayla birlikte blogguncelle sayfasını getir
        }

        public ActionResult GelenBlogSayfasınıGuncelle(Blog b)
        {
            var deger = c.Blogs.Find(b.BlogId);
            deger.Aciklama = b.Aciklama;
            deger.Baslık = b.Baslık;
            deger.BlogImage = b.BlogImage;
            deger.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var deger = c.Yorumlars.ToList();
            return View(deger);
        }

        public ActionResult YorumSil(int id)
        {
            var deger = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumSayfasınıGetir(int id)
        {
            var deger = c.Yorumlars.Find(id);
            return View("YorumSayfasınıGetir", deger);

        }

        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var deger = c.Yorumlars.Find(y.YorumId);
            deger.KullaniciAdi = y.KullaniciAdi;
            deger.Mail = y.Mail;
            deger.Yorum = y.Yorum;
           
            c.SaveChanges();
            return RedirectToAction("YorumListesi",deger);
        }
    }
}