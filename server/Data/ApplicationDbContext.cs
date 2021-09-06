using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :
            base(options)
        {
        }

        public DbSet<Blog> Blog { get; set; }

        public DbSet<Comment> Comment { get; set; }
    }
}
