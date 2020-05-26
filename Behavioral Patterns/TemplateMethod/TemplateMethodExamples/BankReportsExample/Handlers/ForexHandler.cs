using BankReportsExample.Forex;
using System;
using System.Collections.Generic;

namespace BankReportsExample.Handlers
{
    public abstract class ForexHandler
    {
        public void TemplateMethod() 
        {
            var mappedFxOperations = ReadReport();
            var fxOperations = ReconcileFxOperations(mappedFxOperations);
            AddOperationsToTradebook(fxOperations);
        }

        protected abstract List<FxOperation> ReadReport();
        protected abstract void AddOperationsToTradebook(List<FxOperation> fxOperations);

        private List<FxOperation> ReconcileFxOperations(List<FxOperation> fxOperations)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[Accounting] Reconciled {fxOperations.Count} FX Operations.");
            Console.ForegroundColor = ConsoleColor.White;

            fxOperations.ForEach(o => o.SetId(Guid.NewGuid()));
            return fxOperations;
        }
    }
}
