using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DailyTask.Host.Controllers
{
    [ApiController]
    [Route("Task")]
    public class TaskController : ControllerBase
    {
        [HttpGet("{taskName}")]
        public void GetTaskDetails(string taskName)
        {
        }
    }
}
