using TDM.Service.DTOs;

namespace TDM.Service.Interfaces.TaskInterfaces
{
    internal interface ICreateTask
    {
        public TaskDTO CreateTask(TaskDTO task);
    }
}