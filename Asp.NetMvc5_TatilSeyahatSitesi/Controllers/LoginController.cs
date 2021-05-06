using Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult _Login(Admin ad)  //kullanıcı giriş kısmını ayarlama 
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.KullaniciAdi == ad.KullaniciAdi && x.Sifre == ad.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi,false);
                Session["KullaniciAdi"] = bilgiler.KullaniciAdi.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }

        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("_Login", "Login");
        }
    }
}