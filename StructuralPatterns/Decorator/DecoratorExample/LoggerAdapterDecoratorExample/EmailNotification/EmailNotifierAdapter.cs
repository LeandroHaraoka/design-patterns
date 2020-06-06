using LoggerAdapterDecoratorExample.CommandCenter;
using LoggerAdapterDecoratorExample.EmailNotification;
using LoggerAdapterDecoratorExample.Logs;

namespace LoggerAdapterDecoratorExample
{
    public class EmailNotifierAdapter : IOrderNotifier
    {
        private readonly EmailNotifier _emailNotifier;

        public EmailNotifierAdapter(EmailNotifier emailNotifier)
        {
            _emailNotifier = emailNotifier;
        }

        public void NotifyExecution(Order order)
        {
            var orderMessage = OrderMessage.Create(order);

            _emailNotifier.SendEmail(new Email(
                "NEW ORDER EXECUTION", "sender@xpto.com", "new-order-team@xpto.com", orderMessage));
        }

        public void NotifyCancellation(Order order)
        {
            var orderMessage = OrderMessage.Create(order);

            _emailNotifier.SendEmail(new Email(
                "ORDER CANCELLATION", "sender@xpto.com", "cancellation-team@xpto.com", orderMessage));
        }
    }
}
