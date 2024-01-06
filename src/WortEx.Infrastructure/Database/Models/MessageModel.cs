namespace WortEx.Infrastructure.Database.Models;

public class MessageModel
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}