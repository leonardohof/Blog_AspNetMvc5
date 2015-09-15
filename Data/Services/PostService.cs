using Data.Entities;
using Data.Repository;
using PagedList;
using System.Linq;

namespace Data.Services
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepository;

        public PostService(IRepository<Post> postRepository)
        {
            this._postRepository = postRepository;
        }

        public IPagedList<Post> GetAllPosts(int pageNumber, int pageSize)
        {
            return
                _postRepository.Table.OrderByDescending(p => p.Id).ToPagedList(pageNumber, pageSize);
        }

        public Post GetPostById(int postId)
        {
            return
                _postRepository.GetById(postId);
        }
    }
}
