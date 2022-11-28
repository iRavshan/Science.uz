using Microsoft.EntityFrameworkCore;
using Science.Entity;

namespace Science.Data.DataContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
