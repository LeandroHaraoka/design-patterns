using System;

namespace CompositeExamples
{
    public class File : FileSystemComponent
    {
        protected readonly int _sizeInKB;

        public File(string name, int sizeInKB) : base(name)
        {
            _sizeInKB = sizeInKB;
        }

        public override void Print(int depth = 0)
        {
            PrintComponentDetails(depth, ConsoleColor.DarkGreen);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override int GetSize() => _sizeInKB;
    }
}
