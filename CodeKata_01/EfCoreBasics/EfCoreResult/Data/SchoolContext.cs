using EfCoreResult.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreResult.Data
{
    public class SchoolContext : DbContext
    {
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Tutor> Tutors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=SchoolDB;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>(
                g =>
                {
                    g.Property(b => b.Name).HasColumnType("nvarchar(100)").IsRequired(true);
                    g.Property(b => b.LastName).HasColumnType("nvarchar(max)").IsRequired(true);
                    g.Property(b => b.Classyear).HasColumnType("varchar(15)").IsRequired(true);
                    g.OwnsOne(p => p.Adress);
                });

            modelBuilder.Entity<Classroom>(
               ds =>
               {
                   ds.HasIndex(b => b.Name).IsUnique();
                   ds.Property(b => b.Seates).IsRequired(true);
                   ds.Property(b => b.ClassroomNumber).HasColumnName("ClassroomNumber");
               });

            modelBuilder.Entity<Student>().Property<DateTime>("CreatedDate");
            modelBuilder.Entity<Student>().Property<DateTime>("UpdatedDate");

            modelBuilder.Entity<Classroom>().Property<DateTime>("CreatedDate");
            modelBuilder.Entity<Classroom>().Property<DateTime>("UpdatedDate");

            modelBuilder.Entity<Course>().Property<DateTime>("CreatedDate");
            modelBuilder.Entity<Course>().Property<DateTime>("UpdatedDate");

            modelBuilder.Entity<Teacher>().Property<DateTime>("CreatedDate");
            modelBuilder.Entity<Teacher>().Property<DateTime>("UpdatedDate");

        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e =>
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified);

            foreach (var entityEntry in entries)
            {
                entityEntry.Property("UpdatedDate").CurrentValue = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    entityEntry.Property("CreatedDate").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
