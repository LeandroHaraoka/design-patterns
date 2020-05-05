using System;
using System.Collections.Generic;
using System.Text;

namespace StockObserverExample.Stocks
{
    public static class DecimalExtensions
    {
        public static ConsoleColor GetConsoleColor(this decimal value)
        {
            if (value == 0)
                return ConsoleColor.White;
            else if (value > 0)
                return ConsoleColor.Green;
            else
                return ConsoleColor.Red;
        }

        public static string AsString(this decimal value)
        {
            if (value > 0)
                return $"+{value}";
            return value.ToString();
        }
    }
}
