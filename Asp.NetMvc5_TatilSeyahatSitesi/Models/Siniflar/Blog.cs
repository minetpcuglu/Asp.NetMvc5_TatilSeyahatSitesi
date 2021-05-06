using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Baslık { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }

        //ilişkiler 1-n
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}