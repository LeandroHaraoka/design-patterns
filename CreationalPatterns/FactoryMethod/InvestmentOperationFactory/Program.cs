using InvestmentOperationFactory.Aggregates;
using InvestmentOperationFactory.Aggregates.BondCredits;
using InvestmentOperationFactory.Aggregates.Factories;
using InvestmentOperationFactory.Aggregates.FinancialOperations;
using System;
using System.Collections.Generic;

namespace InvestmentOperationFactory
{
    class Program
    {
        private static readonly decimal InvestmentAmount = 100000m;
        private static readonly decimal RetrievalAmount = 50000m;
        private static readonly DateTime MaturityDate = new DateTime(2021, 04, 15);


        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method");
            Console.WriteLine("Investment Operation Example");

            var financialOperations = new List<FinancialOperation>();

            var noTaxesFinancialOperationFactory = new NoTaxesFinancialOperationFactory();
            var taxedFinancialOperationFactory = new TaxedFinancialOperationFactory();
            
            CreateInvestmentAndRetrieval(noTaxesFinancialOperationFactory);
            CreateInvestmentAndRetrieval(taxedFinancialOperationFactory);

            foreach (var operation in financialOperations)
            {
                operation.PrintStatement();
            }

            // Client code
            IList<FinancialOperation> CreateInvestmentAndRetrieval(IFinancialOperationFactory factory)
            {
                var investment = factory.CreateInvestment(InvestmentAmount, MaturityDate, 0.1m);
                var retrieval = factory.CreateRetrieval(RetrievalAmount, MaturityDate, 0.1m);
                financialOperations.Add(investment);
                financialOperations.Add(retrieval);

                return financialOperations;
            }
        }
    }
}
