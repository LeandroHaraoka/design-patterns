using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample.Database
{
    public interface IDatabase
    {
        CountryPopulation GetPopulationFor(string countryName);
    }
}
