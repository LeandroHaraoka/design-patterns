using HomeAndKitchenExample.Products.ValueObjects;
using System.Drawing;

namespace HomeAndKitchenExample.Products.Tables
{
    public class WoodTable : Table
    {
        public WoodTable(Color color, ProductSize size)
        {
            Color = color;
            Size = size;
            Material = ProductMaterial.Wood;
        }
    }
}
