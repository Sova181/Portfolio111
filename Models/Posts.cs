using Microsoft.EntityFrameworkCore;

namespace Portfolio111.Models
{
    public class Posts
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public string? Author { get; set; }


    }
}
