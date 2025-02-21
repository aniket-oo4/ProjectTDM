using TDM.Service.DTOs;

namespace TDM.Service.Interfaces.TaskInterfaces
{
    public interface IGetTask
    {
        public TaskDTO GetTaskById(string id);
        public List<TaskDTO> GetAllTasks();
        public List<TaskDTO> GetTasksByUserId(string userId);
        public List<TaskDTO> GetTasksByProjectId(string projectId);
        public List<TaskDTO> GetTasksByCategoryId(string categoryId);
        public List<TaskDTO> GetTasksByPriorityId(string priorityId);
        public List<TaskDTO> GetTasksByStatusId(string statusId);
    }
}