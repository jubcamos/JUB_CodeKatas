using EfCoreResult.Models;
using EfCoreResults.Models;
using Microsoft.EntityFrameworkCore;


namespace EfCoreResults.Data
{
    public class GameLibraryContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<DeveloperStudio> DeveloperStudios { get; set; }
        public DbSet<DeveloperStudioPublisher> Partnerships { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=GameLibrary;Trusted_Connection=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Game>(
                g =>
                {
                    g.Property(b => b.Name).HasColumnType("varchar(100)");
                    g.Property(b => b.Description).HasColumnType("varchar(max)").IsRequired(false);
                    g.Property(b => b.Genre).HasColumnType("varchar(20)");
                    g.Property(b => b.Price).HasColumnType("decimal(6, 2)");
                });

            modelBuilder.Entity<DeveloperStudio>(
               ds =>
               {
                   ds.Property(b => b.City).HasColumnType("varchar(max)").IsRequired(false);
                   ds.Property(b => b.Country).HasColumnType("varchar(max)").IsRequired(false);
                   ds.Property(b => b.Name).HasColumnType("varchar(100)").IsRequired(false);
               });

            //modelBuilder.Entity<DeveloperStudioPublisher>().HasKey(sc => new { sc.PublisherId, sc.DeveloperId });

            //modelBuilder.Entity<DeveloperStudioPublisher>()
            //    .HasOne<Publisher>(sc => sc.Publisher)
            //    .WithMany(s => s.DeveloperStudioPublisher)
            //    .HasForeignKey(sc => sc.PublisherId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<DeveloperStudioPublisher>()
            //    .HasOne<DeveloperStudio>(sc => sc.DeveloperStudio)
            //    .WithMany(s => s.DeveloperStudioPublisher)
            //    .HasForeignKey(sc => sc.DeveloperId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
