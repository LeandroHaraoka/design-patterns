using BankAccountTransactionsExample.BankAccounts;
using System;

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

            var firstTransaction = new ConcreteTransaction(bankAccount, '+', 10000, Guid.NewGuid());
            var secondTransaction = new ConcreteTransaction(bankAccount, '+', 2000, Guid.NewGuid());
            var thirdTransaction = new ConcreteTransaction(bankAccount, '-', 1000, Guid.NewGuid());
            var fourthTransaction = new ConcreteTransaction(bankAccount, '+', 5000, Guid.NewGuid());

            SendTransaction(firstTransaction);
            SendTransaction(secondTransaction);
            SendTransaction(thirdTransaction);
            SendTransaction(fourthTransaction);

            CancelTransaction(firstTransaction._identifier);
            CancelTransaction(secondTransaction._identifier);

            void SendTransaction(Transaction transaction)
            {
                transactionmanager.SendTransaction(transaction);
                Console.WriteLine($"New Balance: $ {bankAccount.Balance}\n");
            }

            void CancelTransaction(Guid transactionIdentifier)
            {
                transactionmanager.CancelTransaction(transactionIdentifier);
                Console.WriteLine($"New Balance: $ {bankAccount.Balance}\n");
            }
        }
    }
}
