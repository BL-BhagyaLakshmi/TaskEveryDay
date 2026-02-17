

using MediatR;

namespace EveryDayTask.Services.MessagingAbstractions
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }
    
}
