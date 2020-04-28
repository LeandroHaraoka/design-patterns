using FunctionalBuilder.People.Builders;
using System;

namespace FunctionalBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder");
            Console.WriteLine("Functional Builder Example");

            var person = new PersonBuilder()
                .Called("Leandro")
                .WithAge(25)
                .WorkAs("Developer")
                .Build();

            Console.WriteLine($"\nPerson: Name {person.Name} - Age: {person.Age} - Position: {person.Position}");
        }
    }
}
