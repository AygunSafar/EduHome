using System.ComponentModel.DataAnnotations;

namespace EduhomeTask.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public bool IsDeactive { get; set; }
    }
}
