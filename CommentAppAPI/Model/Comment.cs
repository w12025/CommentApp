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

    public Comment() { }
}