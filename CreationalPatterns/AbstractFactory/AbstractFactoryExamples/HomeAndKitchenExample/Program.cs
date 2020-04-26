using HomeAndKitchenExample.Factories;
using HomeAndKitchenExample.Products.ValueObjects;
using SimpleExample.Factories;
using System;
using System.Drawing;

namespace SimpleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory");
            Console.WriteLine("Home and Kitchen Example");

            Console.WriteLine("\nBlue, small and wood chair:");
            CreateChair(ProductMaterial.Wood, Color.Blue, ProductSize.Small);
            Console.WriteLine("\nBlack, medium and wood table:");
            CreateTable(ProductMaterial.Wood, Color.Black, ProductSize.Medium);

            Console.WriteLine("\nRed, small and metal chair:");
            CreateChair(ProductMaterial.Metal, Color.Red, ProductSize.Small);
            Console.WriteLine("\nWhite, large and metal table:");
            CreateTable(ProductMaterial.Metal, Color.White, ProductSize.Large);
        }

        private static void CreateChair(ProductMaterial material, Color color, ProductSize size)
        {
            var factory = HomeAndKitchenFactory.GetConcreteFactory(material);
            var chair = factory.CreateChair(color, size);
            PrintProductDetails(chair.Color, chair.Material, chair.Size);
        }

        private static void CreateTable(ProductMaterial material, Color color, ProductSize size)
        {
            var factory = HomeAndKitchenFactory.GetConcreteFactory(material);
            var table = factory.CreateTable(color, size);
            PrintProductDetails(table.Color, table.Material, table.Size);
        }

        private static void PrintProductDetails(Color color, ProductMaterial material, ProductSize size)
        {
            Console.WriteLine($"Color: {color.Name} - Size: {size} - Material: {material}");
        }
    }
}
