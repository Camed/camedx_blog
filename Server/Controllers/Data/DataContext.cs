using camedx_blog.Shared;
using Microsoft.EntityFrameworkCore;

namespace camedx_blog.Server.Controllers.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

    }
}
