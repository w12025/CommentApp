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
        _dbContext.SaveChanges();
    }

    public Comment GetCommentById(int commentId)
    {
        return _dbContext.Comment.Find(commentId) ?? throw new NullReferenceException("Comment Not Found");
    }

    public IEnumerable<Comment> GetComments()
    {
        return _dbContext.Comment.ToList();
    }

    public int InsertComment(Comment comment)
    {
        Comment newComment = new Comment();
        newComment.MapForInsert(comment);

        _dbContext.Add(newComment);
        _dbContext.SaveChanges();
        return newComment.Id;
    }

    public void UpdateComment(Comment comment)
    {
        _dbContext.Entry(comment).State =
            Microsoft.EntityFrameworkCore.EntityState.Modified;
        _dbContext.SaveChanges();
    }
}