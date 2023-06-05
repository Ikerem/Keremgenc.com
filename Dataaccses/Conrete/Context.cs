using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccses.Conrete
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=KEREMGENCPC\\SQLEXPRESS; initial catalog = KeremNewCv; integrated security = true");

        }

        public DbSet<Home> Homes { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<MyPricing> MyPricings { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<SendMessage> SendMessages { get; set; }
       
    }
}
