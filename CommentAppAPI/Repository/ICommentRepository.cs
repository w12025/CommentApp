using CommentAppAPI.Model;

namespace CommentAppAPI.Repository;

public interface ICommentRepository
{
    public int InsertComment(Comment comment);
    public void UpdateComment(Comment comment);
    public void DeleteComment(int commentId);
    public Comment GetCommentById(int commentId);
    public IEnumerable<Comment> GetComments();
}