using HomeAndKitchenExample.Products.ValueObjects;
using System.Drawing;

namespace HomeAndKitchenExample.Products.Chairs
{
    public class WoodChair : Chair
    {
        public WoodChair(Color color, ProductSize size)
        {
            Color = color;
            Size = size;
            Material = ProductMaterial.Wood;
        }
    }
}
