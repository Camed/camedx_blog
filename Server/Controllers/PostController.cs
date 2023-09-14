using camedx_blog.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace camedx_blog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost()
            {
                Id = new Guid("062D44BD-14FF-4064-A21E-9B9CE7F26DC4"),
                Title = "Papież xD",
                Content = "Co Jan Paweł II tak naprawdę robił z dziećmi xD?",
                ShortDescription = "Krótka historia o Janie Pawle II"
            },
            new BlogPost()
            {
                Id = new Guid("16F7580F-6FF2-4D98-98AB-4C6E6113D2C2"),
                Title = "Krzysztof Gonciarz",
                Content = "Kasia nie wróci bo znalazła Chada z Brazylii...",
                ShortDescription = "Wiemy już, dlaczego Kasia nie wróci!",
            },
        };

        [HttpGet]
        public ActionResult<List<BlogPost>> Get()
        {
            return Ok(Posts);
        }

        [HttpGet("{Id}")]
        public ActionResult<BlogPost> Get(Guid Id)
        {
            var post = Posts.FirstOrDefault(p => p.Id.Equals(Id));

            return post == null ? NotFound() : Ok(post);
        }
    }
}
