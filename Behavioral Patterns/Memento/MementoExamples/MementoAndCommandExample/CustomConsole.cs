﻿using System;

namespace MementoAndCommandExample
{
    public static class CustomConsole
    {
        public static void WriteLine(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
