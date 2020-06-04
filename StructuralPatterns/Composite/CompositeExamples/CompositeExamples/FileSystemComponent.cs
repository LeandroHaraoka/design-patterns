using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeExamples
{
    public abstract class FileSystemComponent
    {
        protected readonly string _name;

        public FileSystemComponent(string name) => _name = name;
        
        public abstract void Print(int depth = 0);
        public abstract int GetSize();

        protected void PrintComponentDetails(int depth, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write('|');
            Console.Write(new string('-', depth * 2));
            Console.WriteLine($"{_name} ({GetSize()} KB)");
        }
    }
}
