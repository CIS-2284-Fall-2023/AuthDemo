using HackerSpace.Shared.Models;

namespace HackerSpace.Server.Interfaces
{
    public interface IPostsRepo
    {
        IEnumerable<Post> GetPosts(int page, int pageSize);
        Post? GetPost(int id);
        Post AddPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int id);
    }
}
