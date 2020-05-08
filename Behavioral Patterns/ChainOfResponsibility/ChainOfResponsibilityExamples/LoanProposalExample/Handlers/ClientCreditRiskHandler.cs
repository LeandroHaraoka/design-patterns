using LoanProposalExample.Clients;
using LoanProposalExample.LoanProposals;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanProposalExample.Handlers
{
    public class ClientCreditRiskHandler : LoanProposalHandler
    {
        private static Dictionary<CreditRisk, decimal> _loanRates = GetLoanRates();

        public override LoanProposal Handle(LoanProposal request)
        {
            Console.WriteLine("\nGetting credit risk rate.");

            var creditRisk = request.ClientPersonalInfo.CreditRisk;

            var foundCreditRisk = _loanRates.TryGetValue(creditRisk, out var rate);

            if (!foundCreditRisk)
                throw new Exception($"No loan rate found to credit risk {creditRisk.ToString()}");

            request.Rate = rate;

            return base.Handle(request);
        }

        private static Dictionary<CreditRisk, decimal> GetLoanRates()
        {
            return new Dictionary<CreditRisk, decimal>
            {
                { CreditRisk.A, 0.8m},
                { CreditRisk.B, 1.5m},
                { CreditRisk.C, 3.0m},
                { CreditRisk.D, 5.0m},
            };
        }
    }
}
