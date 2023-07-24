namespace DeepOrangeTasks.Domain;

public class Task
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Text { get; set; }
    public IEnumerable<string>? Photos { get; set; }
    public IEnumerable<string>? Videos { get; set; }
    public Guid CreateBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public DateTime FinishedAt { get; set; }
}