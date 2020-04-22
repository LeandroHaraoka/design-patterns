using HomeAndKitchenExample.Products.Chairs;
using HomeAndKitchenExample.Products.Tables;
using HomeAndKitchenExample.Products.ValueObjects;
using SimpleExample.Factories;
using System.Drawing;

namespace HomeAndKitchenExample.Factories
{
    public class MetalFactory : IHomeAndKitchenFactory
    {
        public Chair CreateChair(Color color, ProductSize size)
        {
            return new MetalChair(color, size);
        }

        public Table CreateTable(Color color, ProductSize size)
        {
            return new MetalTable(color, size);
        }
    }
}
