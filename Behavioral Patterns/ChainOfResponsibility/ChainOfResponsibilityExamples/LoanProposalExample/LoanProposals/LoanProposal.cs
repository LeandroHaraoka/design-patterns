using LoanProposalExample.Clients;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanProposalExample.LoanProposals
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

        public override string ToString()
        {
            var serializedLoanProposal = JsonConvert.SerializeObject(this, new StringEnumConverter());

            var loanProposalAsJToken = JToken.Parse(serializedLoanProposal);

            return loanProposalAsJToken.ToString(Formatting.Indented);
        }
    }
}
