using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountTransactionsExample.BankAccounts
{
    public class TransactionManager
    {
        private readonly IList<Transaction> _transactions = new List<Transaction>();

        public void SendTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            transaction.Execute();
        }

        public void CancelTransaction(Guid guid)
        {
            var transaction = _transactions.Single(t => t._identifier == guid);

            if (transaction._isExecuted == true)
            {
                transaction.Cancel();
                transaction._isExecuted = false;
            }
        }
    }
}
