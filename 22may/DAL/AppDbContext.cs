using _22may.Models;
using Microsoft.EntityFrameworkCore;

namespace _22may.DAL.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Portofolio> Portofolios { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
