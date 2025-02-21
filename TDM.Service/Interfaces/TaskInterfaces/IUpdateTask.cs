using TDM.Service.DTOs;

namespace TDM.Service.Interfaces.TaskInterfaces
{
    internal interface IUpdateTask
    {        
        public TaskDTO UpdateTask(TaskDTO task);
    }
}