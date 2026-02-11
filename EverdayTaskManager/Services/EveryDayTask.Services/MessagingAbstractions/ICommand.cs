using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayTask.Services.MessagingAbstractions
{

    public interface ICommand : IRequest
    {
    }
    public interface ICommand<TResponse> : IRequest<TResponse>
    {
    }

  
}
