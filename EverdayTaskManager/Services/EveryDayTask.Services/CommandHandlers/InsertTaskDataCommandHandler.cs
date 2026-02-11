using EveryDayTask.Services.Commands;
using EveryDayTask.Services.MessagingAbstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayTask.Services.CommandHandlers
{
    internal class InsertTaskDataCommandHandler : ICommandHandler<InsertTaskDataCommand>
    {
        public Task Handle(InsertTaskDataCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
