using CommentAppAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CommentAppAPI.DBContexts;

public class CommentContext: DbContext
{
    public CommentContext(DbContextOptions<CommentContext> options) : base(options){}
    public DbSet<Comment> Comment { get; set; }
}