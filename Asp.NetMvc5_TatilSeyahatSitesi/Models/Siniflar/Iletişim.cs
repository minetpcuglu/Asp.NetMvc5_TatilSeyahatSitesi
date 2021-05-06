using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar
{
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }
        public string IAdSoyad { get; set; }
        public string Mail { get; set; }
        public string Mesaj { get; set; }
    }
}