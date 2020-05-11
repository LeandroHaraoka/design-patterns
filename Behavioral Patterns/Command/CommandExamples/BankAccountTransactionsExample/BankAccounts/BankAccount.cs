using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountTransactionsExample.BankAccounts
{
    public class BankAccount
    {
        public double Balance { get; private set; }

        public void Deposit(double volume) => Balance += volume;

        public bool Withdrawl(double volume)
        {
            if (Balance < volume)
                return false;

            Balance -= volume;
            return true;
        }

        public void CancelDeposit(double volume) => Balance -= volume;

        public void CancelWithdrawl(double volume) => Balance += volume;
    }
}
