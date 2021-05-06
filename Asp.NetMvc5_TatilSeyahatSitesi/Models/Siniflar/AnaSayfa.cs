using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int AnaSayfaId { get; set; }
        public string Baslik { get; set; }
        public string Acıklama { get; set; }
    }
}