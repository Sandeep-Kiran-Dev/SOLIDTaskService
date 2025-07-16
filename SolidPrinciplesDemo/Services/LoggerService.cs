namespace SolidPrinciplesDemo.Services
{
    public class LoggerService : ILogger
    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[LOG]{DateTime.Now} : {message}");
            Console.ResetColor();        }
    }
}
