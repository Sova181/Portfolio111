using Microsoft.EntityFrameworkCore;

namespace Portfolio111.Models
{
    public class Projects
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; } 
        public DateTime Date { get; set; }
        public long PostsId { get; set; }
        
    }
}
