namespace DeepOrangeTasks.Application.Persistence;

public interface ITaskRepository
{
    Domain.Task? GetTaskById(string id);
    void Add(Domain.Task task);
}