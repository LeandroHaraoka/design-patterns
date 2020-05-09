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
            Console.WriteLine("Bank Account Transactions Example");

            var transactionmanager = new TransactionManager();
            var bankAccount = new BankAccount();

            var firstTransaction = new ConcreteTransaction(bankAccount, Deposit, 10000, Guid.NewGuid());
            var secondTransaction = new ConcreteTransaction(bankAccount, Deposit, 2000, Guid.NewGuid());
            var thirdTransaction = new ConcreteTransaction(bankAccount, Withdrawal, 3000, Guid.NewGuid());
            var fourthTransaction = new ConcreteTransaction(bankAccount, Deposit, 5000, Guid.NewGuid());

            SendTransaction(firstTransaction);
            SendTransaction(secondTransaction);
            SendTransaction(thirdTransaction);
            SendTransaction(fourthTransaction);

            CancelTransaction(firstTransaction._identifier);
            CancelTransaction(secondTransaction._identifier);

            void SendTransaction(Transaction transaction)
            {
                transactionmanager.SendTransaction(transaction);
                
            }

            void CancelTransaction(Guid transactionIdentifier)
            {
                transactionmanager.CancelTransaction(transactionIdentifier);
            }
        }
    }
}
