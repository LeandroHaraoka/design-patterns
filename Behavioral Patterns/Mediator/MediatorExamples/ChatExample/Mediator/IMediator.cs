namespace ChatExample.Mediator
{
    public interface IMediator<TColleague, TData>
    {
        void Register(params TColleague[] colleagues);
        void Send(TColleague from, TData message);
        void Send<T>(TColleague from, TData message) where T : TColleague;
    }
}
