using TDM.Service.DTOs;

namespace TDM.Service.Interfaces.TaskInterfaces
{
    internal interface IUpdateTask
    {        
        public TaskDto UpdateTask(TaskDto task);
    }
}