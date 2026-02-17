using EveryDayTask.Services.MessagingAbstractions;
using EveryDayTask.Services.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayTask.Services.QueryHandlers
{
    internal class GetTaskDataQueryHandler : IQueryHandler<GetTaskDataQuery, string>
    {
       

        public Task<string> Handle(GetTaskDataQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult("hi");
        }

        public Task<string> Handle(IQuery<string> request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
