using System;

namespace LoggerAdapterExample.CommandCenter
{
    public class CustomLogger
    {
        public void NotifyError(string error, string applicationName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[Custom Logger]");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"Date: {DateTime.UtcNow.ToString()}");
            Console.WriteLine($"Application Name: {applicationName}");
            Console.WriteLine($"Error: {error}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void NotifyInfo(string info, string applicationName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[Custom Logger]");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"Date: {DateTime.UtcNow.ToString()}");
            Console.WriteLine($"Application Name: {applicationName}");
            Console.WriteLine($"Info: {info}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
