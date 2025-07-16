using SolidPrinciplesDemo.Models;

namespace SolidPrinciplesDemo.Repositories
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetTasksAysnc();
    }
}
