using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar
{
    public class AdresBlog
    {
        [Key]
        public int AdresId { get; set; }
        public string Baslik { get; set; }
        public string AdresAciklama { get; set; }
        public string AdresMail { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }

    }
}