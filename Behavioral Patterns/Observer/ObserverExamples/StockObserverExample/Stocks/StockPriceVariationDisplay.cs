using System;

namespace StockObserverExample.Stocks
{
    public class StockPriceVariationDisplay : IStockPriceObserver
    {
        private decimal _priceVariation = 0m;
        private decimal _currentPrice;

        public StockPriceVariationDisplay(decimal initialPrice)
        {
            _currentPrice = initialPrice;
        }

        public void Update(decimal updatedValue, string identifier)
        {
            _priceVariation = CalculateVariationRate(_currentPrice, updatedValue);
            _currentPrice = updatedValue;
            Console.Write($"{identifier} Price Variation: ");
            PrintVariation(_priceVariation);
        }

        private decimal CalculateVariationRate(decimal currentValue, decimal newValue)
        {
            var variation = newValue - currentValue;
            var variationRate = variation / currentValue * 100;
            return variationRate;
        }

        private void PrintVariation(decimal variation)
        {
            Console.ForegroundColor = variation.GetConsoleColor();
            var variationAsString = decimal.Round(variation, 4).AsString();
            Console.Write(variationAsString);
            Console.WriteLine("%");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
