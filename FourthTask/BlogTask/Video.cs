using System.Collections.Generic;

namespace FourthTask.BlogTask
{
    public class Video
    {
        public string VideoName { get; set; } = "videoName";
        public string Url { get; set; } = "url";
        public int Views { get; set; } = 0;
        public int Likes { get; set; } = 0;
        public int Dislikes { get; set; } = 0;
        public List<Comment> CommentsList { get; set; } = new();
        
        public Video() {}
        public Video(string videoName)
        {
            VideoName = videoName;
        }
        
        public Video(string videoName, string url) : this(videoName) 
        {
            Url = url;
        }
        
        
        public Video(string videoName, string url, int views) : this(videoName, url) 
        {
            Views = views;
        }
        
        public Video(string videoName, string url, int views, int likes) : this(videoName, url, views) 
        {
            Likes = likes;
        }
        
        public Video(string videoName, string url, int views, int likes, int dislikes) 
            : this(videoName, url, views, likes) 
        {
            Dislikes = dislikes;
        }
        
        public Video(string videoName, string url, int views, int likes, int dislikes, List<Comment> commentsList) 
            : this(videoName, url, views, likes, dislikes) 
        {
            CommentsList = commentsList;
        }
    }
}