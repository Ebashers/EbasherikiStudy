using System.Collections.Generic;

namespace FourthTask.BlogTask
{
    public class Blog
    {
        public string BloggerName { get; set; } = "bloggerName";
        public List<Video> VideosList { get; set; } = new();
        
        public Blog() {}
        public Blog(string bloggerName)
        {
            BloggerName = bloggerName;
        }
        
        public Blog(string bloggerName, List<Video> videosList) : this(bloggerName) 
        {
            VideosList = videosList;
        }
    }
}