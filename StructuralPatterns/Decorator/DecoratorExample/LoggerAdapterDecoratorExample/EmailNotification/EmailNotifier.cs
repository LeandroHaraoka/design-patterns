using LoggerAdapterDecoratorExample.EmailNotification;
using System;

namespace LoggerAdapterDecoratorExample.CommandCenter
{
    public class EmailNotifier
    {
        public void SendEmail(Email email)
        {
            Console.WriteLine("\nEMAIL INBOX");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"[Date] {DateTime.UtcNow.ToString()}");
            Console.WriteLine($"[From] {email.Sender}");
            Console.WriteLine($"[To] {email.Destination}");
            Console.WriteLine($"[Subject] {email.Subject}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"{email.Message}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
    }
}
