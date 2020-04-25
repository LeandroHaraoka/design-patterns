using HomeAndKitchenExample.Products.ValueObjects;
using System.Drawing;

namespace HomeAndKitchenExample.Products.Chairs
{
    public class MetalChair : Chair
    {
        public MetalChair(Color color, ProductSize size)
        {
            Color = color;
            Size = size;
            Material = ProductMaterial.Metal;
        }
    }
}
