using System;

namespace OrderApprovalExample
{
    public class Order : IOrder
    {
        public decimal Volume { get; set; }
        public decimal Price { get; set; }
        public string Product { get; set; }
        public OrderApproval Approval { get; set; }

        public Order(decimal volume, decimal price, string product)
        {
            Volume = volume;
            Price = price;
            Product = product;
        }

        public void Approve(Member approver)
        {
            Console.WriteLine($"Order approved by {approver.Name}.");
            Approval = new OrderApproval(approver.Id, DateTime.UtcNow);
        }  
    }

    public class OrderApproval
    {
        public Guid Approver { get; set; }
        public DateTime ApprovedAt { get; set; }

        public OrderApproval(Guid approver, DateTime approvedAt)
        {
            Approver = approver;
            ApprovedAt = approvedAt;
        }
    }
}
