using LegacyCodesExample.Adapters;
using System;

namespace LegacyCodesExample
{
    public class ClientService
    {
        private readonly IComplexFinancialCalculus _complexFinancialCalculus;
        public ClientService(IComplexFinancialCalculus complexFinancialCalculus)
        {
            _complexFinancialCalculus = complexFinancialCalculus;
        }

        public void Execute() =>
            _complexFinancialCalculus.Calculate(1000, 0.5m, DateTime.Today.AddDays(-10), DateTime.Today.AddDays(10));
    }
}
