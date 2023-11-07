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

// GET request to retrieve all comments
    [HttpGet]
    public IEnumerable<Comment> GetAll()
    {
        // Retrieve and return all comments from the repository
        return _commentRepository.GetComments();
    }

// GET request to retrieve a comment by its ID
    [HttpGet]
    [Route("{id}")]
    public Comment Get(int id)
    {
        // Retrieve and return a comment by its ID from the repository
        return _commentRepository.GetCommentById(id);
    }

// POST request to insert a new comment
    [HttpPost]
    public string Insert(Comment comment)
    {
        // Insert the provided comment into the repository and get the assigned ID
        int id = _commentRepository.InsertComment(comment);
        // Return a message indicating that the comment was added with its new ID
        return "ADDED WITH ID = " + id;
    }

// PUT request to update an existing comment
    [HttpPut]
    public string Update(Comment comment)
    {
        // Update the provided comment in the repository
        _commentRepository.UpdateComment(comment);
        // Return a message indicating that the comment was updated
        return "UPDATED";
    }

// DELETE request to delete a comment by its ID
    [HttpDelete]
    [Route("{id}")]
    public string Delete(int id)
    {
        // Delete a comment by its ID from the repository
        _commentRepository.DeleteComment(id);
        // Return a message indicating that the comment was deleted
        return "DELETED";
    }
}