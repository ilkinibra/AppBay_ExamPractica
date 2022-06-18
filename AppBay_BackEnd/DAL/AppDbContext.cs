using AppBay_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace AppBay_BackEnd.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Modern> Moderns { get; set; }
    }
}
