using ChainOfResponsibilityExamples.LoanProposals;
using ChainOfResponsibilityExamples.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityExamples.Handlers
{
    public class ClientInfoHandler : LoanProposalHandler
    {
        public override LoanProposal Handle(LoanProposal request)
        {
            Console.WriteLine("\nGetting client personal information.");
            var clientId = request.ClientId;

            var repo = new ClientRepository();
            
            var clientPersonalInfo = repo.Find(x => x.Id == clientId).FirstOrDefault();

            request.ClientPersonalInfo = clientPersonalInfo;

            return base.Handle(request);
        }
    }
}
