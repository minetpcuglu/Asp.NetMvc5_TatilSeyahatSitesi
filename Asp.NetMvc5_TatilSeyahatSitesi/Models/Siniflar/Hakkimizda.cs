using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaId { get; set; }
        public string FotoUrl { get; set; }
        public string Aciklama { get; set; }
    }
}