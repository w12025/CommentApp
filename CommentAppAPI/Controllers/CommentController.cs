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
    [Route("{id}")]
    public Comment Get(int id)
    {
        return _commentRepository.GetCommentById(id);
    }

    [HttpPost]
    public string Insert(Comment comment)
    {
        int id = _commentRepository.InsertComment(comment);
        return "ADDED WITH ID = " + id;
    }

    [HttpPut]
    public string Update(Comment comment)
    {
        _commentRepository.UpdateComment(comment);
        return "UPDATED";
    }

    [HttpDelete]
    [Route("{id}")]
    public String Delete(int id)
    {
        _commentRepository.DeleteComment(id);
        return "DELETED";
    }
}