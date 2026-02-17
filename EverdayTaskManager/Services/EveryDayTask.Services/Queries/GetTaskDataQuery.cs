using EveryDayTask.Services.MessagingAbstractions;


namespace EveryDayTask.Services.Queries
{
    public class GetTaskDataQuery : IQuery<string>
    {
        public string TaskName { get; }
        public GetTaskDataQuery(string taskName)
        {
            TaskName = taskName;
        }
    }
}
