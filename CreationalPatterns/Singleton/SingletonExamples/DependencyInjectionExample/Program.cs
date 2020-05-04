using DependencyInjectionExample.Database;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton");
            Console.WriteLine("Singleton Dependency Injection Example");

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IDatabase, SingletonDatabase>()
                .AddSingleton<CountryReader>()
                .BuildServiceProvider();

            var database = serviceProvider.GetService<IDatabase>();
            var brazilPopulation = database.GetPopulationFor("Brazil");
            var japanPopulation = database.GetPopulationFor("Japan");
            Console.WriteLine($"Brazil Population: {brazilPopulation.PopulationAmount}");
            Console.WriteLine($"Japan Population:  {japanPopulation.PopulationAmount}");
            
            var countryReader = serviceProvider.GetService<CountryReader>();
            var totalPopulation = countryReader.GetTotalPopulationFor(new List<string> { "Brazil", "Japan" });
            Console.WriteLine($"Total Population:  {totalPopulation}");

            var secondCountryReader = serviceProvider.GetService<CountryReader>();
            var secondDatabase = serviceProvider.GetService<IDatabase>();
            Console.WriteLine(
                $"\nHas ServiceProvider.GetService<CountryReader> generated a single instance? {countryReader == secondCountryReader}");
            Console.WriteLine(
                $"Has ServiceProvider.GetService<IDatabase> generated a single instance? {database == secondDatabase}");
        }
    }
}
