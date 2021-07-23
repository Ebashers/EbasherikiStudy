using System.Collections.Generic;

namespace FirstTask.Models
{
    public class Blog
    {
        public int id { get; set; }
        public string BloggerName { get; set; }    
        public List<Video> VideosList { get; set; } 
        
    }
}