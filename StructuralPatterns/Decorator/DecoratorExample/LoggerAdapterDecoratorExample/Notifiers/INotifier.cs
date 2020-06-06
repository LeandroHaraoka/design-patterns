using System;

namespace LoggerAdapterDecoratorExample.Logs
{
    public interface IOrderNotifier
    {
        void NotifyExecution(Order order);
        void NotifyCancellation(Order order);
    }
}
