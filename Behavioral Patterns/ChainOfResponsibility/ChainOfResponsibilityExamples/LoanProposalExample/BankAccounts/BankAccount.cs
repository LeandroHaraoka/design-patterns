using System;
using System.Collections.Generic;
using System.Text;

namespace LoanProposalExample.BankAccounts
{
    public class BankAccount
    {
        public Guid ClientId { get; set; }
        public int BankIdentifier { get; set; }
        public string Account { get; set; }
        public string Agency { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(Guid clientId, int bankIdentifier, string account, string agency, decimal balance)
        {
            ClientId = clientId;
            BankIdentifier = bankIdentifier;
            Account = account;
            Agency = agency;
            Balance = balance;
        }
    }
}
