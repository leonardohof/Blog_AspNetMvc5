using Data.Entities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public partial interface IPostService
    {
        Post GetPostById(int postId);

        IPagedList<Post> GetAllPosts(int pageNumber, int pageSize);
    }
}
