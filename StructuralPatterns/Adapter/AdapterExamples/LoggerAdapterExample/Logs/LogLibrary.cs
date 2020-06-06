using System;

namespace LoggerAdapterExample.Logs
{
    public class LogLibrary : ILogger
    {
        public void LogError(Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[LogLibrary]");
            Console.WriteLine($"Error: {exception.Message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[LogLibrary]");
            Console.WriteLine($"Info: {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
