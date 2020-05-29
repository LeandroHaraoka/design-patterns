using System;

namespace LoggerAdapterExample.Logs
{
    public class LogLibrary : ILogger
    {
        public void LogError(Exception exception)
        {
            Console.WriteLine("\n[LogLibrary]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Error: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{exception.Message}");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("\n[LogLibrary]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Info: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{message}");
        }
    }
}
