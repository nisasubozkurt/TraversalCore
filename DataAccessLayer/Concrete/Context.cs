using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-TO0C5CS2;database=TraversalDB;integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın
        public DbSet<About2> Abouts2 { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın
        public DbSet<Contact> Contacts { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın
        public DbSet<Destination> Destinations { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın
        public DbSet<Feature> Features { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın
        public DbSet<Feature2> Features2 { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın
        public DbSet<Guide> Guides { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın
        public DbSet<Newsletter> Newsletters { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın
        public DbSet<SubAbout> SubAbouts { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın
        public DbSet<Testimonial> Testimonials { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın
        public DbSet<Comment> Comments { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın
        public DbSet<Reservation> Reservations { get; set; } // s takılı hali tablo ismi olsun, entity ile karışmasın


    }
}
