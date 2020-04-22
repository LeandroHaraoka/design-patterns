using HomeAndKitchenExample.Products.ValueObjects;
using System.Drawing;

namespace HomeAndKitchenExample.Products.Chairs
{
    public abstract class Chair
    {
        public Color Color { get; set; }
        public ProductSize Size { get; set; }
        public ProductMaterial Material { get; set; }
    }
}
