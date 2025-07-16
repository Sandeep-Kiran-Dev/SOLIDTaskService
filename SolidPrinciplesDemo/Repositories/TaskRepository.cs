using SolidPrinciplesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public async Task<List<TaskItem>> GetTasksAysnc()
        {
            await Task.Delay(100); //Simulate DB 
            return new List<TaskItem> { 
                new TaskItem { Id = 1, Title = "First", IsCompleted = false },
                new TaskItem { Id = 2, Title = "Second", IsCompleted = true } 

            
            }; 
        }
    }
}
