using System;

namespace EduhomeTask.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string By { get; set; }
       
        public string Image { get; set; }
        public DateTime CraeteTime { get; set; }
    }
}
