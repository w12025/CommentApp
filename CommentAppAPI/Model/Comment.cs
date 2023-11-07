namespace CommentAppAPI.Model;

public class Comment
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public string Username { get; set; }

    public Comment(int id, string title, string? description, string username)
    {
        Id = id;
        Title = title;
        Description = description;
        Username = username;
    }

    public Comment()
    {
    }

    public Comment MapForInsert(Comment comment)
    {
        this.Title = comment.Title;
        this.Description = comment.Description;
        this.Username = comment.Username;
        return this;
    }
}