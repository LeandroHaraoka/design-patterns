using SmartphoneFactoryExample.Smartphones;
using SmartphoneFactoryExample.Smartphones.Factories;
using System;

namespace SmartphoneFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method");
            Console.WriteLine("Smartphone Factory Example");

            var appleSmartphoneFactory = new AppleSmartphoneFactory();
            CreateAllSmartphones(appleSmartphoneFactory);
            var samsungSmartphoneFactory = new SamsungSmartphoneFactory();
            CreateAllSmartphones(samsungSmartphoneFactory);
        }

        private static void CreateAllSmartphones(ISmartphoneFactory smartphoneFactory)
        {
            var lowCostSmartphone = smartphoneFactory.CreateLowCost();
            PrintSmartphoneInfo(lowCostSmartphone);
            var hypedSmartphone = smartphoneFactory.CreateHyped();
            PrintSmartphoneInfo(hypedSmartphone);
            var luxuriousSmartphone = smartphoneFactory.CreateLuxurious();
            PrintSmartphoneInfo(luxuriousSmartphone);

        }

        private static void PrintSmartphoneInfo(Smartphone smartphone)
        {
            Console.WriteLine($"\nSmartphone:");
            Console.WriteLine($"    Name: {smartphone.Name}");
            Console.WriteLine($"    RandomAccessMemory: {smartphone.RandomAccessMemory}");
            Console.WriteLine($"    Processor: {smartphone.Processor}");
            Console.WriteLine($"    Year: {smartphone.Year}");
        }
    }
}
