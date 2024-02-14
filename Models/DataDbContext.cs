using Microsoft.EntityFrameworkCore;

namespace Portfolio111.Models
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options)
          : base(options)
        {
        }

        public DbSet<Posts> Posts { get; set; } = null!;
        public DbSet<Projects> Projects { get; set; } = null!;
        public DbSet<Reviews> Reviews { get; set; } = null!;
    }
}
