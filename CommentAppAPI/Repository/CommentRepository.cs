using CommentAppAPI.Model;

namespace CommentAppAPI.Repository
{
	public class CommentRepository : ICommentRepository
	{
		public void InsertComment(Comment comment) { }
		public void UpdateComment(Comment comment) { }
		public void DeleteComment(int commentId) { }

		public Comment GetCommentById(int commentId)
		{
			throw new Exception();
		}

		public IEnumerable<Comment> GetComments()
		{
			throw new Exception();
		}
	}
}