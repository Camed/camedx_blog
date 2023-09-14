using camedx_blog.Shared;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;

namespace camedx_blog.Client.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly HttpClient http;

        public BlogPostService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<BlogPost?> GetBlogPostById(Guid? id)
        {
            if (id.HasValue)
            {
                var result = await http.GetAsync($"api/post/{id.Value}");
                if(result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var message = await result.Content.ReadAsStringAsync();
                    return new BlogPost { Title =  "Blog post not found!"};
                }
                else 
                {
                    return await result.Content.ReadFromJsonAsync<BlogPost>();
                }
            }
            return null;
        }

        public async Task<List<BlogPost>> GetBlogPosts()
        {
            return await http.GetFromJsonAsync<List<BlogPost>>("api/post");
        }
    }
}
