using EveryDayTask.Services.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using EveryDayTask.Services.Queries;

namespace DailyTask.Host.Controllers
{
    [ApiController]
    [Route("Task")]
    public class TaskController : ControllerBase
    {
        public IMediator _mediator { get; }

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("Details/{taskName}")]
        public void GetTaskDetails(string taskName)
        {
            var getTaskDataQuery = new GetTaskDataQuery(taskName);
            var r = _mediator.Send(getTaskDataQuery);
        }

        [HttpPost("insert")]
        public void InsertTaskData(string taskName)
        {
            var insertCommand = new InsertTaskDataCommand();
                _mediator.Send(insertCommand);
        }

        [HttpDelete("delete/{taskName}")]
        public void DeleteTask()
        {
            var deleteCommand = new DeleteTaskDataCommand();
            _mediator.Send(deleteCommand);

        }
    }
}
