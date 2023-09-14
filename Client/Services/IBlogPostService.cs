using camedx_blog.Shared;

namespace camedx_blog.Client.Services
{
    public interface IBlogPostService
    {
        Task<List<BlogPost>> GetBlogPosts();
        Task<BlogPost?> GetBlogPostById(Guid? id);
    }
}
