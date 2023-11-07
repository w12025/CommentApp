using CommentAppAPI.Model;

namespace CommentAppAPI.Repository;

public interface ICommentRepository
{
    public Comment InsertComment(Comment comment);
    public Comment UpdateComment(Comment comment);
    public void DeleteComment(int commentId);
    public Comment GetCommentById(int commentId);
    public IEnumerable<Comment> GetComments();
}