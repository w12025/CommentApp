using CommentAppAPI.DBContexts;
using CommentAppAPI.Model;

namespace CommentAppAPI.Repository;

public class CommentRepository : ICommentRepository
{
    private readonly CommentContext _dbContext;

    public CommentRepository(CommentContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void DeleteComment(int commentId)
    {
        var comment = _dbContext.Comment.Find(commentId);
        _dbContext.Comment.Remove(comment ?? throw new NullReferenceException("Comment Not Found"));
        Save();
    }

    public Comment GetCommentById(int commentId)
    {
        return _dbContext.Comment.Find(commentId) ?? throw new NullReferenceException("Comment Not Found");
    }

    public IEnumerable<Comment> GetComments()
    {
        return _dbContext.Comment.ToList();
    }

    public Comment InsertComment(Comment comment)
    {
        _dbContext.Add(comment);
        Save();
        return _dbContext.Comment.Find(comment.Id) ?? throw new NullReferenceException();
    }

    private void Save()
    {
        _dbContext.SaveChanges();
    }

    public Comment UpdateComment(Comment comment)
    {
        _dbContext.Entry(comment).State =
            Microsoft.EntityFrameworkCore.EntityState.Modified;
        Save();
        return _dbContext.Comment.Find(comment.Id) ?? throw new NullReferenceException("Comment Not Found");
    }
}