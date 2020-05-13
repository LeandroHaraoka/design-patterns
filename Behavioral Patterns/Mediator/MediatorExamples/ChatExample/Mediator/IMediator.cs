using System;
using System.Collections.Generic;
using System.Text;

namespace ChatExample.Mediator
{
    public interface IMediator<TColleague, TData>
    {
        void Register(TColleague colleague);
        void Send(TColleague from, TData colleague);
        void Send<T>(TColleague from, TData colleague) where T : TColleague;
    }
}
