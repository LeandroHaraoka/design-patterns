using ChainOfResponsibilityExamples.BankAccounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibilityExamples.Repository
{
    public class BankAccountRepository : IRepository<BankAccount>
    {
        private static IQueryable<BankAccount> _bankAccounts = GetBankAccounts();

        public IEnumerable<BankAccount> Find(Func<BankAccount, bool> filter)
        {
            return _bankAccounts.Where(filter);
        }

        private static IQueryable<BankAccount> GetBankAccounts() =>
            new List<BankAccount>
            {
                new BankAccount(
                    new Guid("406acba3-4b4c-4879-b13c-1a019f0c27f1"),
                    001,
                    "0000-1",
                    "0001",
                    1000),
                new BankAccount(
                    new Guid("123acba3-5b6c-4879-b13c-1a019f0c27a4"),
                    002,
                    "0000-2",
                    "0002",
                    500)
            }
            .AsQueryable();
    }
}
