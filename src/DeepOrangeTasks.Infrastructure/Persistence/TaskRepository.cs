using DeepOrangeTasks.Application.Persistence;

namespace DeepOrangeTasks.Infrastructure.Persistence;

public class TaskRepository : ITaskRepository
{
    public void Add(Domain.Task task)
    {
        throw new NotImplementedException();
    }

    public Domain.Task? GetTaskById(string id)
    {
        throw new NotImplementedException();
    }
}