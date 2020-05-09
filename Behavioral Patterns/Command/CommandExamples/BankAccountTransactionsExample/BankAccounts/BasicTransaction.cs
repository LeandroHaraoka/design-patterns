using System;

namespace BankAccountTransactionsExample.BankAccounts
{
    public class BasicTransaction : Transaction
    {
        public BasicTransaction(BankAccount bankAccount, Transactions transactions, double volume, Guid identifier) 
            : base(bankAccount, transactions, volume, identifier)
        {
        }
    }
}
