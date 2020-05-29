using System;

namespace LoggerAdapterExample.CommandCenter
{
    public class CommandCenterLogger
    {
        public void EmitAlert(string error, string applicationName)
        {
            Console.WriteLine("\n[Command Center]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"Date: {DateTime.UtcNow.ToString()}");
            Console.WriteLine($"Application Name: {applicationName}");
            Console.WriteLine($"Error: {error}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
