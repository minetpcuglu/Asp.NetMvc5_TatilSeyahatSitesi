using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar
{
    public class BlogYorum
    {
        //IEnumreable belli sayıdaki değerleri yazan toplayan yapı 
        public IEnumerable<Blog> Deger1 { get; set; } //proop olustur
        public IEnumerable<Yorumlar> Deger2 { get; set; } //yorumlar için proop
        public IEnumerable<Blog> Deger3 { get; set; }

        public IEnumerable<Yorumlar> Deger4 { get; set; } //yorumlar için proop
    }
}