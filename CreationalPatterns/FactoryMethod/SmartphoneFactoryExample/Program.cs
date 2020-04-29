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
            PrintBondCreditInfo(lowCostSmartphone);
            var hypedSmartphone = smartphoneFactory.CreateHyped();
            PrintBondCreditInfo(hypedSmartphone);
            var luxuriousSmartphone = smartphoneFactory.CreateLuxurious();
            PrintBondCreditInfo(luxuriousSmartphone);

        }

        private static void PrintBondCreditInfo(Smartphone smartphone)
        {
            Console.WriteLine($"\nSmartphone:");
            Console.WriteLine($"    Name: {smartphone.Name}");
            Console.WriteLine($"    RandomAccessMemory: {smartphone.RandomAccessMemory}");
            Console.WriteLine($"    Processor: {smartphone.Processor}");
            Console.WriteLine($"    Year: {smartphone.Year}");
        }
    }
}
