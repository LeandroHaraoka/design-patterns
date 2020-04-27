using BuilderInheritanceExample.People;
using BuilderInheritanceExample.People.Builders;
using System;

namespace BuilderInheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Builder");
            Console.WriteLine("Builder Inheritance Example");

            var person = new PersonAuxiliaryBuilder()
                .WithName("Leandro")
                .WithAge(25)
                .WorkAs("Developer")
                .Build();
            
            Console.WriteLine($"\nPerson: Name {person.Name} - Age: {person.Age} - Position: {person.Position}");
        }
    }
}
