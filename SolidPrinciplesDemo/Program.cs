using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SolidPrinciplesDemo.Repositories;
using SolidPrinciplesDemo.Services;

namespace SolidPrinciplesDemo
{
    internal class Program
    {
        static async Task Main(string[] args) 
        {
            using IHost host = Host.CreateDefaultBuilder(args).
                ConfigureServices(services =>
                        services.AddScoped<ITaskRepository, TaskRepository>()
                                .AddScoped<ILogger, LoggerService>()
                                .AddScoped<TaskService>()).Build();

            //Get the service from the DI container
            var service = host.Services.GetRequiredService<TaskService>();
            await service.PrintTasksAsync();

            //ITaskRepository taskRepository = new TaskRepository();
            //var service = new TaskService(taskRepository);
            //await service.PrintTasksAsync();
        }
    }
}