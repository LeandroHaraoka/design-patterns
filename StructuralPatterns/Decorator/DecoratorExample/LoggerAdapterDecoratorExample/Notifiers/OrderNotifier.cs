using LoggerAdapterDecoratorExample.Logs;

namespace LoggerAdapterDecoratorExample
{
    public class OrderNotifierDecorator : IOrderNotifier
    {
        private readonly IOrderNotifier _logger;
        private readonly IOrderNotifier _emailNotifier;

        public OrderNotifierDecorator(IOrderNotifier logger, IOrderNotifier emailNotifierAdapter)
        {
            _logger = logger;
            _emailNotifier = emailNotifierAdapter;
        }

        public void NotifyExecution(Order order)
        {
            _logger.NotifyExecution(order);
            _emailNotifier.NotifyExecution(order);
        }

        public void NotifyCancellation(Order order)
        {
            _logger.NotifyCancellation(order);
            _emailNotifier.NotifyCancellation(order);
        }
    }
}
