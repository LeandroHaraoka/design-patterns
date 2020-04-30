using System;

namespace PrototypeCompleteExample.People
{
    public class Person : Prototype
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Document Document { get; set; }

        public override Prototype DeepCopy() =>this.DeepCopy<Person>();

        public override void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"DocumentType: {Document.Type}");
            Console.WriteLine($"DocumentValue: {Document.Value}");
        }
    }
}
