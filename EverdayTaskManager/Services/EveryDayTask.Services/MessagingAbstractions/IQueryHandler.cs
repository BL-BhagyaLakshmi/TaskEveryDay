

using MediatR;

namespace EveryDayTask.Services.MessagingAbstractions
{
    public interface IQueryHandler<TQuery,TResponse> : IRequestHandler<IQuery<TResponse>, TResponse>
        where TQuery:IQuery<TResponse>
    {
    }
}
