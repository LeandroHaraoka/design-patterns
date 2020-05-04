using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadSafeExample.Database
{
    public interface IDatabase
    {
        CountryPopulation GetPopulationFor(string countryName);
    }
}
