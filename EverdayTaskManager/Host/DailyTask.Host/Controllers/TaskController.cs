using EveryDayTask.Services.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

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

        [HttpGet("taskDetails/{taskName}")]
        public void GetTaskDetails(string taskName)
        {

        }

        [HttpGet("insert")]
        public void InsertTaskData(string taskName)
        {
            var insertCommand = new InsertTaskDataCommand();
                _mediator.Send(insertCommand);
        }
    }
}
