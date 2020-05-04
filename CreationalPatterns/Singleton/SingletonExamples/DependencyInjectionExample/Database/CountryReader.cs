using System;
using System.Collections.Generic;

namespace DependencyInjectionExample.Database
{
    public class CountryReader
    {
        private IDatabase _database;

        public CountryReader(IDatabase database)
        {
            _database = database;
            Console.WriteLine("\nCountry Reader Initialized.");
        }

        public int GetTotalPopulationFor(IEnumerable<string> countries)
        {
            int result = 0;
            foreach (var country in countries)
                result += _database.GetPopulationFor(country).PopulationAmount;
            return result;
        }
    }
}
