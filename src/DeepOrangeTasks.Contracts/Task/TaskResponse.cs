namespace DeepOrangeTasks.Contracts.Task;

public record TaskResponse(
    Guid Id,
    string Title,
    string Content,
    string CreatedBy,
    DateTime createdAt,
    DateTime updateAt,
    DateTime finishedAt
);