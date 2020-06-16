using System;

namespace OrderApprovalExample
{
    public class OrderProxy : IOrder
    {
        private readonly Order _order;

        public OrderProxy(Order order)
        {
            _order = order;
        }

        public void Approve(Member approver)
        {
            if (approver.Role != Role.ReaderWriter && approver.Role != Role.Writer)
            {
                Console.WriteLine($"Order can not be approved by {approver.Name}.");
                return;
            }

            _order.Approve(approver);
        }
    }
}
