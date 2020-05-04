using System;
using System.Collections.Generic;

namespace ThreadSafeExample.Database
{
    public class SingletonDatabase
    {
        private static SingletonDatabase _instance;
        private static IDictionary<string, CountryPopulation> _countriesPopulation;
        private static readonly object _lock = new Object();

        public static SingletonDatabase GetInstance()
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new SingletonDatabase();
                        Console.WriteLine("\nDatabase Initialized.");
                    }
                }
            }

            return _instance;
        }

        public CountryPopulation GetPopulationFor(string name)
        {
            _countriesPopulation.TryGetValue(name, out var result);

            return result;
        }

        private SingletonDatabase()
        {
            _countriesPopulation = CreateDataSet();
            Console.WriteLine("Data Set Initialized.\n");
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
