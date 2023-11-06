using Microsoft.AspNetCore.Mvc;
using CommentAppAPI.Model;

namespace CommentAppAPI.Controllers
{
    [ApiController]
    [Route("api/v1/")]
    public class CommentController : ControllerBase
    {
        private readonly ILogger<CommentController> _logger;

        public CommentController(ILogger<CommentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("comments")]
        public IEnumerable<Comment> Get()
        {
            return null;
        }

        [HttpGet]
        [Route("comments/{id}")]
        public Comment Get(int id)
        {
            return new Comment() { Id = id };
        }

        [HttpPost]
        [Route("comments")]
        public Comment Post(Comment comment)
        {
            return null;
        }

        [HttpPut]
        [Route("comments/{id}")]
        public Comment Put(int id, Comment comment)
        {
            return null;
        }

        [HttpDelete]
        [Route("comments/{id}")]
        public String Delete(int id)
        {
            return "DELETED";   
        }

    }
}