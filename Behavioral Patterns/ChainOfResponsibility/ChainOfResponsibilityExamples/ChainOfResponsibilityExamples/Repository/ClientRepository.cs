using LoanProposalExample.Clients;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoanProposalExample.Repository
{
    public class ClientRepository : IRepository<Client>
    {
        private static IQueryable<Client> _clients = GetClients();

        public IEnumerable<Client> Find(Func<Client, bool> filter)
        {
            return _clients.Where(filter);
        }

        private static IQueryable<Client> GetClients() => 
            new List<Client> 
            {
                new Client(
                    new Guid("406acba3-4b4c-4879-b13c-1a019f0c27f1"),
                    "My First Client Name",
                    new Document(DocumentType.CPF, "123456789-00"),
                    "Street Name, 123.",
                    "+55 11 91234-5678",
                    CreditRisk.B),
                new Client(
                    new Guid("123acba3-5b6c-4879-b13c-1a019f0c27a4"),
                    "My Second Client Name",
                    new Document(DocumentType.CPF, "987654321-00"),
                    "Street Name, 456.",
                    "+55 11 98765-4321",
                    CreditRisk.D)
            }
            .AsQueryable();
    }
}
