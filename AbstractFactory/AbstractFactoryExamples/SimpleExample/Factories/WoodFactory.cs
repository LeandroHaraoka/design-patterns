using HomeAndKitchenExample.Products.Chairs;
using HomeAndKitchenExample.Products.Tables;
using HomeAndKitchenExample.Products.ValueObjects;
using SimpleExample.Factories;
using System.Drawing;

namespace HomeAndKitchenExample.Factories
{
    public class WoodFactory : IHomeAndKitchenFactory
    {
        public Chair CreateChair(Color color, ProductSize size)
        {
            return new WoodChair(color, size);
        }

        public Table CreateTable(Color color, ProductSize size)
        {
            return new WoodTable(color, size);
        }
    }
}
