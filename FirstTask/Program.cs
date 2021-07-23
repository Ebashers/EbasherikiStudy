using FirstTask.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await using var context = new MyDbContext();
            await context.Database.MigrateAsync();
            var comments = await context.Comments.ToListAsync();
            var videos = await context.Videos.ToListAsync();
            var blog = await context.Blogs.ToListAsync();

            int GetViewsSum()
            {
                var viewsSum = (from video in videos select video.Views).Sum();
                return viewsSum;
            }
            

            bool HasTopComment()
            {
                var topComments = comments.Where(c => c.Likes > c.Video.Likes).ToList();
                bool isTopComment = topComments.Any();
                return isTopComment;
            }

            List<string> MostDislikedVideos()
            {
                int mostDislikes = videos.Select(v => v.Dislikes).Max();
                var mostDislikesList = context.Videos.Where(v => v.Dislikes == mostDislikes);
                List<string> mostDislikesNamesList = new List<string>(); 
                foreach (var video in mostDislikesList)
                { 
                    mostDislikesNamesList.Add(video.VideoName);   
                }
                return mostDislikesNamesList;
            }

            Console.WriteLine("Sum of views: " + GetViewsSum());
            Console.WriteLine(HasTopComment()
                ? "There is a comment that got more likes than a video"
                : "There is NO comment that got more likes than a video");
            Console.WriteLine("Most disliked videos: ");
            foreach (var video in MostDislikedVideos())
            {
                Console.WriteLine(video);
            }
        }
    }
}
