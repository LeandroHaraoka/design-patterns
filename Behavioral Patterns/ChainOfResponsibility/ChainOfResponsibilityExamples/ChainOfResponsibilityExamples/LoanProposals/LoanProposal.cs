using ChainOfResponsibilityExamples.Clients;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityExamples.LoanProposals
{
    public class LoanProposal
    {
        public Guid ClientId { get; set; }
        public Client ClientPersonalInfo { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }

        public LoanProposal(Guid clientId, decimal amount)
        {
            ClientId = clientId;
            Amount = amount;
        }
    }
}
