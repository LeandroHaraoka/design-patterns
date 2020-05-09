using System;

namespace BankAccountTransactionsExample.BankAccounts
{
    public class ConcreteTransaction : Transaction
    {
        public ConcreteTransaction(BankAccount bankAccount, char direction, double volume, Guid identifier) 
            : base(bankAccount, direction, volume, identifier)
        {
        }
    }
}
