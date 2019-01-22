using JTracker.jtcontext.Models;
using Microsoft.EntityFrameworkCore;

namespace JTracker.jtcontext
{
    public class JTContext : DbContext
    {
        public DbSet<Log> Log { get; set; }
        public DbSet<Config> Config { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=jira.cetjy9swwdzy.us-west-1.rds.amazonaws.com;database=jtracker;user=jtrack;password=Letmeenter1!");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Publisher>(entity =>
            //{
            //    entity.HasKey(e => e.ID);
            //    entity.Property(e => e.Name).IsRequired();
            //});

            //modelBuilder.Entity<Book>(entity =>
            //{
            //    entity.HasKey(e => e.ISBN);
            //    entity.Property(e => e.Title).IsRequired();
            //    entity.HasOne(d => d.Publisher)
            //      .WithMany(p => p.Books);
            //});
        }
    }
}