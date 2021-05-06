using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp.NetMvc5_TatilSeyahatSitesi.Models.Siniflar
{
    public class Context:DbContext
    { 
        //olusturmak istediğimiz tabloları yazalım
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
    }
}