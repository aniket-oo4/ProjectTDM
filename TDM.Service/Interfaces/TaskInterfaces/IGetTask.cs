using TDM.Service.DTOs;

namespace TDM.Service.Interfaces.TaskInterfaces
{
    public interface IGetTask
    {
        public TaskDto GetTaskById(string id);
        public List<TaskDto> GetAllTasks();
        public List<TaskDto> GetTasksByUserId(string userId);
        public List<TaskDto> GetTasksByProjectId(string projectId);
        public List<TaskDto> GetTasksByCategoryId(string categoryId);
        public List<TaskDto> GetTasksByPriorityId(string priorityId);
        public List<TaskDto> GetTasksByStatusId(string statusId);
    }
}