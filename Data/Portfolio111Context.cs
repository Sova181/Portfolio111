using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portfolio111.Models;

namespace Portfolio111.Data
{
    public class Portfolio111Context : DbContext
    {
        public Portfolio111Context (DbContextOptions<Portfolio111Context> options)
            : base(options)
        {
        }

        public DbSet<Portfolio111.Models.Posts> Posts { get; set; } = default!;
        public DbSet<Portfolio111.Models.Projects> Projects { get; set; } = default!;
        public DbSet<Portfolio111.Models.Reviews> Reviews { get; set; } = default!;
    }
}
