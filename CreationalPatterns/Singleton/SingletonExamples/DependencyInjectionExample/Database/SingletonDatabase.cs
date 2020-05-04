using System;
using System.Collections.Generic;

namespace DependencyInjectionExample.Database
{
    public class SingletonDatabase : IDatabase
    {
        private static IDictionary<string, CountryPopulation> _countriesPopulation;

        public SingletonDatabase()
        {
            _countriesPopulation = CreateDataSet();
            Console.WriteLine("\nDatabase and Data Set Initialized.");
        }

        public CountryPopulation GetPopulationFor(string name)
        {
            _countriesPopulation.TryGetValue(name, out var result);

            return result;
        }


        private Dictionary<string, CountryPopulation>  CreateDataSet()
        {
            return
                new Dictionary<string, CountryPopulation>
                {
                    { "Japan", new CountryPopulation("Japan", 126476461) },
                    { "China", new CountryPopulation("China", 1439323776) },
                    { "India", new CountryPopulation("India", 1380004385) },
                    { "United States", new CountryPopulation("United States", 331002651) },
                    { "Brazil", new CountryPopulation("Brazil", 212559417) }
                };
        }
    }
}
