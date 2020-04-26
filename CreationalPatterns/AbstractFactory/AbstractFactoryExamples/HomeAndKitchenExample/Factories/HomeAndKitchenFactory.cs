using HomeAndKitchenExample.Factories;
using HomeAndKitchenExample.Products.Chairs;
using HomeAndKitchenExample.Products.Tables;
using HomeAndKitchenExample.Products.ValueObjects;
using System;
using System.Drawing;

namespace SimpleExample.Factories
{
    public abstract class HomeAndKitchenFactory
    {
        public static HomeAndKitchenFactory GetConcreteFactory(ProductMaterial material)
        {
            switch (material) 
            {
                case ProductMaterial.Wood: return new WoodFactory();
                case ProductMaterial.Metal: return new MetalFactory();
                default: throw new ArgumentException("Please provide a valid product material.");
            }
        }

        public abstract Chair CreateChair(Color color, ProductSize size);
        public abstract Table CreateTable(Color color, ProductSize size);
    }
}
