using System.Text;

namespace LoggerAdapterDecoratorExample
{
    public static class OrderMessage
    {
        public static string Create(Order order)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Id: {order.Id}");
            sb.AppendLine($"Buyer: {order.Buyer}");
            sb.AppendLine($"Seller: {order.Seller}");
            sb.AppendLine($"Product: {order.Product}");
            sb.AppendLine($"Volume: {order.Volume}");
            sb.Append($"Price: {order.Price}");
            return sb.ToString();
        }
    }
}
