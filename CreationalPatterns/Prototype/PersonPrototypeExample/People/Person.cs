using System;
using System.Collections.Generic;
using System.Text;

namespace PersonPrototypeExample.People
{
    public class Person : Prototype
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Document Document { get; set; }

        public override Prototype ShallowCopy() => (Person) this.MemberwiseClone();

        public override Prototype DeepCopy()
        {
            var newPerson = (Person) this.MemberwiseClone();
            newPerson.Name = Name;
            newPerson.Document = new Document(Document.Type, Document.Value);
            return newPerson;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"DocumentType: {Document.Type}");
            Console.WriteLine($"DocumentValue: {Document.Value}");
        }
    }
}
