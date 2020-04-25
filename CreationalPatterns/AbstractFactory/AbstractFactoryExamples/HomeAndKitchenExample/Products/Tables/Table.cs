using HomeAndKitchenExample.Products.ValueObjects;
using System.Drawing;

namespace HomeAndKitchenExample.Products.Tables
{
    public abstract class Table
    {
        public Color Color { get; set; }
        public ProductSize Size { get; set; }
        public ProductMaterial Material { get; set; }
    }
}
