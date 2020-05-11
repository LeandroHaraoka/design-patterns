using System;
using BankAccountTransactionsExample.BankAccounts;
using static BankAccountTransactionsExample.BankAccounts.Transactions;

namespace BankAccountTransactionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Command");
            Console.WriteLine("Bank Account Transactions Example\n");

            var transactionmanager = new TransactionManager();
            var bankAccount = new BankAccount();

            var firstTransaction = new BasicTransaction(bankAccount, Deposit, 5000, Guid.NewGuid());
            var lastTransaction = new BasicTransaction(bankAccount, Deposit, 2000, Guid.NewGuid());

            transactionmanager.SendTransaction(firstTransaction);
            transactionmanager.SendTransaction(new BasicTransaction(bankAccount, Deposit, 10000, Guid.NewGuid()));
            transactionmanager.SendTransaction(new BasicTransaction(bankAccount, Withdrawal, 3000, Guid.NewGuid()));
            transactionmanager.SendTransaction(lastTransaction);

            transactionmanager.CancelTransaction(firstTransaction._identifier);
            transactionmanager.CancelTransaction(lastTransaction._identifier);
        }
    }
}
