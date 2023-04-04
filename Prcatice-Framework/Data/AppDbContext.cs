using Microsoft.EntityFrameworkCore;
using Prcatice_Framework.Models;

namespace Prcatice_Framework.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }
      
        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Blog> Blogs { get; set; }
    }
}
