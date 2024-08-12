using KlassyCafe.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.DAL.Context
{
    public class KlassyContext :DbContext
    {
        public KlassyContext(DbContextOptions<KlassyContext> options) :base(options)
        {
           
        }

        public  DbSet<About> Abouts { get; set; }
        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<Rezervation> Rezervations { get; set; }
        public  DbSet<Slider> Sliders { get; set; }
        public  DbSet<Table> Tables { get; set; }
    }
}
