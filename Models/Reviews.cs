using Microsoft.EntityFrameworkCore;

namespace Portfolio111.Models
{
    public class Reviews
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public long ProjectsId { get; set; }
    }
}
