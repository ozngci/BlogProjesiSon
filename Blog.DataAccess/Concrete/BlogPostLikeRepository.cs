using Blog.DataAccess.Abstract;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete
{
    public class BlogPostLikeRepository : IBlogPostLikeRepository
    {
        public Task<BlogPostLike> AddLikeForBlog(BlogPostLike blogPostLike)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTotalLikes(Guid blogPostId)
        {
            throw new NotImplementedException();
        }
    }
}
