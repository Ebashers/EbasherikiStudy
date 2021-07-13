using Microsoft.EntityFrameworkCore;
using EFUniversity.Models;

namespace EFUniversity.DB
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Institute> Institutes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Task6;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Institute>().ToTable("Institutes");
            modelBuilder.Entity<Institute>().HasData(
                new Institute { Id = 1, Name = "KPI" }
                );

            modelBuilder.Entity<Faculty>().ToTable("Faculties");
            modelBuilder.Entity<Faculty>().HasOne(f => f.Institute).WithMany(i => i.Faculties).HasForeignKey(f => f.InstituteId);
            modelBuilder.Entity<Faculty>().HasData(
                new Faculty { Id = 1, Name = "FIOT", InstituteId = 1 },
                new Faculty { Id = 2, Name = "Parasha", InstituteId = 1 }
                );
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Student>().HasOne(s => s.Faculty).WithMany(f => f.Students).HasForeignKey(s => s.FacultyId);
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Ruslan", Surname = "Shudra", Grade = 95.2, FacultyId = 1 },
                new Student { Id = 2, Name = "Bob", Surname = "Pickford", Grade = 98, FacultyId = 2 },
                new Student { Id = 3, Name = "Kolya", Surname = "Yeban", Grade = 0, FacultyId = 1 }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
