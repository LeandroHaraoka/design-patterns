using ClonablePersonExample.People;
using System;

namespace ClonablePersonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype");
            Console.WriteLine("Clonable Person Example");

            var originalPerson = new Person()
            {
                Name = "Hara",
                Age = 25,
                Document = new Document(DocumentType.CPF, "xxx.xxx.xxx-xx")
            };

            var clonePerson = (Person) originalPerson.Clone();
            
            Console.WriteLine("\nPerson clone before update");
            clonePerson.PrintDetails();

            originalPerson.Name = "Hara LTDA.";
            originalPerson.Age = 0;
            originalPerson.Document.Type = DocumentType.CNPJ;
            originalPerson.Document.Value = "xx.xxx.xxx/xxxx-xx";
            
            Console.WriteLine("\nPerson clone after update");
            clonePerson.PrintDetails();
        }
    }
}
