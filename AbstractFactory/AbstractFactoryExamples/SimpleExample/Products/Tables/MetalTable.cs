using HomeAndKitchenExample.Products.ValueObjects;
using System.Drawing;

namespace HomeAndKitchenExample.Products.Tables
{
    public class MetalTable : Table
    {
        public MetalTable(Color color, ProductSize size)
        {
            Color = color;
            Size = size;
            Material = ProductMaterial.Metal;
        }
    }
}
