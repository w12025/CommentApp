using Microsoft.AspNetCore.Mvc;
using CommentAppAPI.Model;
using CommentAppAPI.Repository;

namespace CommentAppAPI.Controllers;

[ApiController]
[Route("api/v1/comments")]
public class CommentController : ControllerBase
{
    private readonly ICommentRepository _commentRepository;

    public CommentController(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }

    [HttpGet]
    public IEnumerable<Comment> GetAll()
    {
        return _commentRepository.GetComments();
    }

    [HttpGet]
    [Route("/{id}")]
    public Comment Get(int id)
    {
        return _commentRepository.GetCommentById(id);
    }

    [HttpPost]
    public Comment Insert(Comment comment)
    {
        return _commentRepository.InsertComment(comment);
    }

    [HttpPut]
    public Comment Update(Comment comment)
    {
        return _commentRepository.UpdateComment(comment);
    }

    [HttpDelete]
    [Route("/{id}")]
    public String Delete(int id)
    {
        _commentRepository.DeleteComment(id);
        return "DELETED";
    }
}