namespace FirstTask.Models
{
    public class Comment
    {
        public int id { get; set; } 
        public string CommentText { get; set; } 
        public int Likes { get; set; } 
        public int Dislikes { get; set; } 
        public Video Video { get; set; }
        public int VideoId { get; set; }
    }
}