using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountTransactionsExample.BankAccounts
{
    public class BankAccount
    {
        private double _balance;
        public double Balance { get => _balance; }

        public void ProcessTransation(char direction, double volume)
        {
            _balance += direction == '+' ? volume : volume.RevertSign();
        }
    }

    public static class DoubleExtensions
    {
        public static double RevertSign(this double value)
        {
            return -value;
        }
    }
}
