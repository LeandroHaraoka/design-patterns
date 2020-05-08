using LoanProposalExample.Handlers;
using LoanProposalExample.LoanProposals;
using System;

namespace LoanProposalExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsibility");
            Console.WriteLine("Loan Proposal Example");

            var handler = new ClientInfoHandler();
            var clientCreditRiskHandler = new ClientCreditRiskHandler();
            var bankAccountHandler = new BankAccountHandler();
            var sendProposalHandler = new SendProposalHandler();
            
            handler.SetNext(clientCreditRiskHandler).SetNext(bankAccountHandler).SetNext(sendProposalHandler);

            var loanProposal = new LoanProposal(new Guid("406acba3-4b4c-4879-b13c-1a019f0c27f1"), 1500);
            
            var sentLoanProposal = handler.Handle(loanProposal);

            Console.WriteLine(sentLoanProposal);
        }
    }
}
