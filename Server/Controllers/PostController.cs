using camedx_blog.Server.Controllers.Data;
using camedx_blog.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace camedx_blog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly DataContext _context;

        public PostController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<BlogPost>> Get()
        {
            return Ok(_context.BlogPosts);
        }

        [HttpGet("{Id}")]
        public ActionResult<BlogPost> Get(Guid Id)
        {
            var post = _context.BlogPosts.FirstOrDefault(p => p.Id.Equals(Id));

            return post == null ? NotFound() : Ok(post);
        }
    }
}
