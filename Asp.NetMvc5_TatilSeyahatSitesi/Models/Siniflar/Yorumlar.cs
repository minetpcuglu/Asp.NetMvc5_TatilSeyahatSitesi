using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public  int YorumId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }

        //İlişkiler 1-1
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }  //sanal bir değere dönüştürmek için virtual
    }
}