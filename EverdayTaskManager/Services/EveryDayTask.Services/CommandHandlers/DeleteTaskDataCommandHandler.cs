using EveryDayTask.Services.Commands;
using EveryDayTask.Services.MessagingAbstractions;

namespace EveryDayTask.Services.CommandHandlers
{
    public class DeleteTaskDataCommandHandler : ICommandHandler<DeleteTaskDataCommand>
    {
        public Task Handle(DeleteTaskDataCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
