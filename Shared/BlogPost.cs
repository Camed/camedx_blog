using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camedx_blog.Shared
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsModified { get; set; }
    }
}
