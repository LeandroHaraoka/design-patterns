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
            Console.WriteLine("Abstract Factory Example");

            var metalFactory = new MetalFactory();
            var woodFactory = new WoodFactory();

            Console.WriteLine("\nBlue, small and wood chair:");
            CreateChair(woodFactory, Color.Blue, ProductSize.Small);
            Console.WriteLine("\nBlack, medium and wood table:");
            CreateTable(woodFactory, Color.Black, ProductSize.Medium);

            Console.WriteLine("\nRed, small and metal chair:");
            CreateChair(metalFactory, Color.Red, ProductSize.Small);
            Console.WriteLine("\nWhite, large and metal table:");
            CreateTable(metalFactory, Color.White, ProductSize.Large);
        }

        private static void CreateChair(IHomeAndKitchenFactory factory, Color color, ProductSize size)
        {
            var chair = factory.CreateChair(color, size);
            PrintProductDetails(chair.Color, chair.Material, chair.Size);
        }

        private static void CreateTable(IHomeAndKitchenFactory factory, Color color, ProductSize size)
        {
            var table = factory.CreateTable(color, size);
            PrintProductDetails(table.Color, table.Material, table.Size);
        }

        private static void PrintProductDetails(Color color, ProductMaterial material, ProductSize size)
        {
            Console.WriteLine($"Color: {color.Name} - Size: {size} - Material: {material}");
        }
    }
}
