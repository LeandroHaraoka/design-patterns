using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExamples
{
    public class Directory : FileSystemComponent
    {
        protected readonly List<FileSystemComponent> _children = new List<FileSystemComponent>();

        public Directory(string name) : base(name)
        {
        }

        public override void Print(int depth = 0)
        {
            PrintComponentDetails(depth, ConsoleColor.Magenta);
            _children.ForEach(c => c.Print(depth + 1));
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Add(FileSystemComponent child) => _children.Add(child);
        public void Remove(FileSystemComponent child) => _children.Remove(child);

        public override int GetSize() => _children.Sum(c => c.GetSize());
    }
}
