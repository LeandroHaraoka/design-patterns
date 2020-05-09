using System;

namespace BankAccountTransactionsExample.BankAccounts
{
    public abstract class Transaction
    {
        public readonly BankAccount _bankAccount;
        public readonly Transactions _transaction;
        public readonly double _volume;
        public readonly Guid _identifier;
        public bool _isExecuted;

        public Transaction(BankAccount bankAccount, Transactions transaction, double volume, Guid identifier)
        {
            _bankAccount = bankAccount;
            _transaction = transaction;
            _volume = volume;
            _identifier = identifier;
        }

        public void Execute() 
        {
            if (_transaction == Transactions.Withdrawal)
                _isExecuted = _bankAccount.Withdrawl(_volume);

            if (_transaction == Transactions.Deposit)
            {
                _bankAccount.Deposit(_volume);
                _isExecuted = true;
            }

            if (_isExecuted == true)
            {
                Console.WriteLine($"Processed Transaction: {_transaction} $ {_volume} ({_identifier})");
                Console.WriteLine($"New Balance: $ {_bankAccount.Balance}\n");
            }
        }

        public void Cancel()
        {
            if (_transaction == Transactions.Withdrawal)
                _bankAccount.CancelWithdrawl(_volume);

            if (_transaction == Transactions.Deposit)
            {
                _bankAccount.CancelDeposit(_volume);
            }

            Console.WriteLine($"Cancelled Transaction: {_transaction} $ {_volume} ({_identifier})");
            Console.WriteLine($"New Balance: $ {_bankAccount.Balance}\n");
        }
    }

    public enum Transactions
    {
        Deposit,
        Withdrawal
    }
}
