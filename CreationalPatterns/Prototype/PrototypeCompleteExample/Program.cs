using PrototypeCompleteExample.People;
using System;

namespace PrototypeCompleteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype");
            Console.WriteLine("Prototype Complete Example");

            var peopleRegistry = new PeopleRegistry();

            var malePerson = peopleRegistry.CreatePerson("male");
            Console.WriteLine("\nMale template");
            malePerson.PrintDetails();
            
            malePerson.Name = "Hara";
            malePerson.Age = 25;
            malePerson.Document.Value = "123.456.789.99";
            Console.WriteLine("\nMale Person");
            malePerson.PrintDetails();

            var femalePerson = peopleRegistry.CreatePerson("female");
            Console.WriteLine("\nFemale template");
            femalePerson.PrintDetails();

            femalePerson.Name = "Anne";
            femalePerson.Age = 30;
            femalePerson.Document.Value = "987.654.321.11";
            Console.WriteLine("\nFemale person");
            femalePerson.PrintDetails();
        }
    }
}
