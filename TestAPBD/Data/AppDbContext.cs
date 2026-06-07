using Microsoft.EntityFrameworkCore;
using TestAPBD.Entities;

namespace TestAPBD.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Nursery> Nursery { get; set; }
        public DbSet<Tree_Species> Tree_Species { get; set; }
        public DbSet<Seedling_Batch> Seedling_Batch { get; set; }
        public DbSet<Responsible> Responsible { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
