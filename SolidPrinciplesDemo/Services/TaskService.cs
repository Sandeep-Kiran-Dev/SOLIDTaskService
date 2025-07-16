using SolidPrinciplesDemo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _repository;
        private readonly ILogger _logger;
        public TaskService(ITaskRepository taskRepository, ILogger logger)
        {
            _repository = taskRepository;            
            _logger = logger;

        }

        public async Task PrintTasksAsync()
        {
            _logger.Log("Fetching the Tasks...");
            try
            {
                var tasks = await _repository.GetTasksAysnc();
                foreach (var item in tasks)
                {
                    Console.WriteLine($"[{(item.IsCompleted ? "X" : " ")}]{item.Title}");
                }
                _logger.Log("All the Tasks are printed");
            }
            catch (Exception ex)
            {
                _logger.Log("Error in printing the tasks");
            }
        }
    }
}
