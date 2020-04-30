using PersonPrototypeExample.People;
using System;

namespace PersonPrototypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype");
            Console.WriteLine("Person Prototype Example");

            var originalPerson = new Person()
            {
                Name = "Hara",
                Age = 25,
                Document = new Document(DocumentType.CPF, "xxx.xxx.xxx-xx")
            };

            var shallowCopy = originalPerson.ShallowCopy();
            var deepCopy = originalPerson.DeepCopy();
            Console.WriteLine("\nPerson copies before update");
            PrintOutput();

            originalPerson.Name = "Hara LTDA.";
            originalPerson.Age = 0;
            originalPerson.Document.Type = DocumentType.CNPJ;
            originalPerson.Document.Value = "xx.xxx.xxx/xxxx-xx";
            Console.WriteLine("\nPerson copies after update");
            PrintOutput();

            void PrintOutput()
            {
                Console.WriteLine($"\nShallow copy");
                shallowCopy.PrintDetails();

                Console.WriteLine($"\nDeep copy");
                deepCopy.PrintDetails();
            }
        }
    }
}
