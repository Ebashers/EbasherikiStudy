using FirstTask.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstTask.DB
{
    public class MyDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Video> Videos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Task6;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Blog>().ToTable("Blogs");
            modelBuilder.Entity<Blog>().HasData(
                new Blog {id = 1, BloggerName = "Eles"}
            );
            modelBuilder.Entity<Video>().ToTable("Videos");
            modelBuilder.Entity<Video>().HasOne(v => v.Blog).
                WithMany(b => b.VideosList).HasForeignKey(v => v.BlogId);
            modelBuilder.Entity<Video>().HasData(
                new Video {id = 1, VideoName = "Warface: НАЧАТЬ С НУЛЯ?", Url = "https://www.youtube.com/watch?v=jgELCkPJ4LQ",
                    Views = 1791927, Likes = 30764, Dislikes = 5672, BlogId = 1},
                new Video {id = 2, VideoName = "Intro для канала Элез", Url = "https://www.youtube.com/watch?v=6vshj3lPUx0",
                    Views = 4516796, Likes = 19809, Dislikes = 5020, BlogId = 1}
            );
            modelBuilder.Entity<Comment>().ToTable("Comments");
            modelBuilder.Entity<Comment>().HasOne(c => c.Video).
                WithMany(v => v.CommentsList).HasForeignKey(c => c.VideoId);
            modelBuilder.Entity<Comment>().HasData(
                new Comment {id = 1, CommentText = "' Всем привет, с вами Элез '  Мне больше нравился ^_^ ", 
                    Likes = 159, Dislikes = 15, VideoId = 1},
                new Comment {id = 2, CommentText = "6 лет назад... и тут рекомендация", 
                    Likes = 10, Dislikes = 1, VideoId = 1},
                new Comment {id = 3, CommentText = "Мне кажется,Элез бы отлично сыграл Джокера. Пугающе. Именно.", 
                    Likes = 228000000, Dislikes = 28, VideoId = 2},
                new Comment {id = 4, CommentText = "у меня мурашки по коже когда он разговаривает", 
                    Likes = 8, Dislikes = 0, VideoId = 2}
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
