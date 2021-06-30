namespace FourthTask.Blog
{
    public class Comment
    {
        public string CommentText { get; set; } = "commentText";
        public int Likes { get; set; } = 0;
        public int Dislikes { get; set; } = 0;
        
        public Comment() {}
        public Comment(string commentText)
        {
            CommentText = commentText;
        }
        
        
        public Comment(string commentText, int likes) : this(commentText) 
        {
            Likes = likes;
        }
        
        public Comment(string commentText, int likes, int dislikes) : this(commentText, likes) 
        {
            Dislikes = dislikes;
        }
        
    }
}