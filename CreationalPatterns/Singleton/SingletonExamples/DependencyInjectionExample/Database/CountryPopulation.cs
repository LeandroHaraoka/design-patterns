using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample.Database
{
    public class CountryPopulation
    {
        public string CountryName { get; set; }
        public int PopulationAmount { get; set; }

        public CountryPopulation(string countryName, int populationAmount)
        {
            CountryName = countryName;
            PopulationAmount = populationAmount;
        }
    }
}
