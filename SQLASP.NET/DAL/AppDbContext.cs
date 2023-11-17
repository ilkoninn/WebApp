
namespace SQLASP.NET.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){ }
        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Works> Works { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<WorkImages> WorkImages { get; set; }
    }
}
