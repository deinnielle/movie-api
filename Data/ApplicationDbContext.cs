using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Director> Director { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().HasMany(d => d.Movies).WithOne(d => d.Director);
            modelBuilder.Entity<Movie>().HasOne(m => m.Director).WithMany(m => m.Movies);
        }
    }
}