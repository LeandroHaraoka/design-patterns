using ChainOfResponsibilityExamples.Handlers;
using ChainOfResponsibilityExamples.LoanProposals;
using System;

namespace ChainOfResponsibilityExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsibility");
            Console.WriteLine("Chain of Responsibility Example");

            var handler = new ClientInfoHandler();
            var clientCreditRiskHandler = new ClientCreditRiskHandler();
            var bankAccountHandler = new BankAccountHandler();
            var sendProposalHandler = new SendProposalHandler();
            
            handler.SetNext(clientCreditRiskHandler).SetNext(bankAccountHandler).SetNext(sendProposalHandler);

            var loanProposal = new LoanProposal(new Guid("406acba3-4b4c-4879-b13c-1a019f0c27f1"), 1500);
            
            handler.Handle(loanProposal);
        }
    }
}
