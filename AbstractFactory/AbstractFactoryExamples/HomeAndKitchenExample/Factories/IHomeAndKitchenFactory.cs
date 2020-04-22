using HomeAndKitchenExample.Products.Chairs;
using HomeAndKitchenExample.Products.Tables;
using HomeAndKitchenExample.Products.ValueObjects;
using System.Drawing;

namespace SimpleExample.Factories
{
    public interface IHomeAndKitchenFactory
    {
        Chair CreateChair(Color color, ProductSize size);
        Table CreateTable(Color color, ProductSize size);
    }
}
