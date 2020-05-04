using System;
using ThreadSafeExample.Database;

namespace ThreadSafeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton");
            Console.WriteLine("Singleton ThreadSafe Example");

            var database = SingletonDatabase.GetInstance();
            var brazilPopulation = database.GetPopulationFor("Brazil");

            Console.WriteLine($"Brazil info:");
            Console.WriteLine($"CountryName: {brazilPopulation.CountryName}");
            Console.WriteLine($"Population: {brazilPopulation.PopulationAmount}");
            
            var databaseSecondInstance = SingletonDatabase.GetInstance();
            Console.WriteLine($"\nHas SingletonDatabase.GetInstance generated a single instance? {database == databaseSecondInstance}");

        }
    }
}
