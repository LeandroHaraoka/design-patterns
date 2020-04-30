using System;
using System.Collections.Generic;
using System.Text;

namespace ClonablePersonExample.People
{
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Document Document { get; set; }

        public object Clone() => this.MemberwiseClone();

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"DocumentType: {Document.Type}");
            Console.WriteLine($"DocumentValue: {Document.Value}");
        }
    }
}
