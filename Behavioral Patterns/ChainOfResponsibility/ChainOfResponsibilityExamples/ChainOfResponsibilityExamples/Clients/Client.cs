using ChainOfResponsibilityExamples.BankAccounts;
using System;

namespace ChainOfResponsibilityExamples.Clients
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Document Document { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public CreditRisk CreditRisk { get; set; }

        public Client(Guid id, string name, Document document, string address, string phone, CreditRisk creditRisk)
        {
            Id = id;
            Name = name;
            Document = document;
            Address = address;
            Phone = phone;
            CreditRisk = creditRisk;
        }
    }
}
