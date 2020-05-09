using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountTransactionsExample.BankAccounts
{
    public class BankAccount
    {
        private double _balance;
        public double Balance { get => _balance; }

        public void Deposit(double volume) => _balance += volume;

        public bool Withdrawl(double volume)
        {
            if (_balance < volume)
                return false;

            _balance -= volume;
            return true;
        }
        public void CancelDeposit(double volume) => _balance -= volume;

        public void CancelWithdrawl(double volume) => _balance += volume;
    }
}
