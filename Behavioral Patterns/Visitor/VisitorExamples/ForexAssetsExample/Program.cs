using ForexAssetsExample.ForexOperations;
using System;
using static ForexAssetsExample.ForexOperations.Direction;
using static ForexAssetsExample.ForexOperations.OptionType;
using static ForexAssetsExample.ForexOperations.CurrencyPair;
using static ForexAssetsExample.ForexOperations.ExecutionType;
using ForexAssetsExample.Visitors;
using System.Collections.Generic;

namespace ForexAssetsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visitor");
            Console.WriteLine("Forex Assets Example");
            PrintHeader();

            var fxOperations = new List<FxOperation>
            {
                new FxForwardContract(DateTime.UtcNow, USDBRL, 1000, 6m, Buy,
                    DateTime.UtcNow.AddDays(60), DateTime.UtcNow.AddDays(62)),

                new FxVanillaOption(DateTime.UtcNow, USDBRL, 1000, 50, 5m, 6m, Call, European, Buy,
                    DateTime.UtcNow.AddDays(60), DateTime.UtcNow.AddDays(62)),

                new FxVanillaOption(DateTime.UtcNow, USDBRL, 1000, 50, 5m, 6m, Put, European, Buy,
                    DateTime.UtcNow.AddDays(60), DateTime.UtcNow.AddDays(62))
            };

            var spotRate = 6.5m;
            fxOperations.ForEach(f => GeneratePnlForOperation(f, spotRate));
        }

        private static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSee below the PnL for some FX Operations.");
            Console.WriteLine("USDBRL Spot rate: 6.5");
            Console.ForegroundColor = ConsoleColor.White;
        }


        private static void GeneratePnlForOperation(FxOperation fxOperation, decimal spotRate)
        {
            var calculatePnl = fxOperation.CalculatePnL(new PnLCalculusVisitor(spotRate));
            fxOperation.DisplayPnL(new PnLDisplayVisitor(calculatePnl));
        }
    }
}
