using HackerSpace.Server.Interfaces;
using HackerSpace.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HackerSpace.Server.Controllers
{
    [Authorize(Roles ="Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostsRepo _postsRepo;

        public PostsController(IPostsRepo postsRepo)
        {
            _postsRepo = postsRepo;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("{page:int}/{pageSize:int}")]
        public IEnumerable<Post> GetAllPosts(int page, int pageSize)
        {
            return _postsRepo.GetPosts(page, pageSize);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("{id:int}")]
        public Post? GetPost(int id)
        {
            return _postsRepo.GetPost(id);
        }

        [HttpPost]
        public void PostPost(Post post)
        {
            _postsRepo.AddPost(post);
        }

        [HttpPut]
        public void PutPost(Post post)
        {
            _postsRepo.UpdatePost(post);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public void DeletePost(int id)
        {
            _postsRepo.DeletePost(id);
        }
    }
}
