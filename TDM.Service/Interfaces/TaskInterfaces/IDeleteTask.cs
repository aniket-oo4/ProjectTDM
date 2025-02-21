using TDM.Service.DTOs;

namespace TDM.Service.Interfaces.TaskInterfaces
{
    internal interface IDeleteTask
    {
        public TaskDto DeleteTask(string id);
    }
}