using ChainOfResponsibilityExamples.LoanProposals;
using System;

namespace ChainOfResponsibilityExamples.Handlers
{
    public abstract class LoanProposalHandler : IHandler<LoanProposal> 
    {
        private IHandler<LoanProposal> _next;

        public virtual LoanProposal Handle(LoanProposal request)
        {
            if (_next != null)
                return _next.Handle(request);
            
            return request;
        }

        public IHandler<LoanProposal> SetNext(IHandler<LoanProposal> handler)
        {
            _next = handler;
            return _next;
        }
    }
}
