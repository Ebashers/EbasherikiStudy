using FirstTask.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstTask.DB
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Task6;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FirstName = "Ruslan", LastName = "Shudra" },
                new Student { Id = 2, FirstName = "Bob", LastName = "Pickford" }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
