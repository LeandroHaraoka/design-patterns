using LoanProposalExample.LoanProposals;
using LoanProposalExample.Repository;
using System;
using System.Linq;

namespace LoanProposalExample.Handlers
{
    public class BankAccountHandler : LoanProposalHandler
    {
        public override LoanProposal Handle(LoanProposal request)
        {
            Console.WriteLine("\nValidating bank account balance.");

            var clientId = request;

            var repo = new BankAccountRepository();

            var bankAccount = repo.Find(x => x.ClientId == request.ClientId).FirstOrDefault();

            if (bankAccount.Balance < request.Amount * 0.5m)
                throw new Exception($"The client bank account must have at least 50% of the required loan amount.");

            return base.Handle(request);
        }
    }
}
