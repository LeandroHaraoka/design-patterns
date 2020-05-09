using System;

namespace BankAccountTransactionsExample.BankAccounts
{
    public class ConcreteTransaction : Transaction
    {
        public ConcreteTransaction(BankAccount bankAccount, Transactions transactions, double volume, Guid identifier) 
            : base(bankAccount, transactions, volume, identifier)
        {
        }
    }
}
