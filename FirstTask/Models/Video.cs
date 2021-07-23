using System.Collections.Generic;

namespace FirstTask.Models
{
    public class Video
    {
        public int id { get; set; }
        public string VideoName { get; set; } 
        public string Url { get; set; } 
        public int Views { get; set; } 
        public int Likes { get; set; } 
        public int Dislikes { get; set; } 
        public List<Comment> CommentsList { get; set; } 
        public Blog Blog { get; set; }
        public int BlogId { get; set; }
        
    }
}