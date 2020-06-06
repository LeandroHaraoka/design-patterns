namespace LoggerAdapterDecoratorExample.EmailNotification
{
    public class Email
    {
        public string Subject { get; set; }
        public string Sender { get; set; }
        public string Destination { get; set; }
        public string Message { get; set; }

        public Email(string subject, string sender, string destination, string message)
        {
            Subject = subject;
            Sender = sender;
            Destination = destination;
            Message = message;
        }
    }
}
