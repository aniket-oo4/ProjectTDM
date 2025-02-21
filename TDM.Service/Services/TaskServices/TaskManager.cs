using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.Service.DTOs;
using TDM.Service.Interfaces.TaskInterfaces;

namespace TDM.Service.Services.TaskServices
{


    public class TaskManager : IGetTask,IUpdateTask,ICreateTask,IDeleteTask
    {
        public TaskManager()
        {
        }

        public List<TaskDto> GetAllTasks()
        {
            try
            {

            throw new NotImplementedException();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public TaskDto GetTaskById(string id)
        {
            try
            {

                return new TaskDto()
                {
                    Id = 1,
                    Name = "Sample Task",
                    Description = "This is a sample task description.",
                    StatusId = "1",
                    AssignedBy = "1",
                    AssignedOn = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(7),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(7),
                    CreatedBy = 1,
                    CreatedOn = DateTime.Now,
                    UpdatedBy = 1,
                    UpdatedOn = DateTime.Now,
                    PriorityId = 1,
                    CategoryId = 1,
                    ProjectId = 1,
                    UserId = 1,
                    TotalTimeSpent = "5h",
                    UDF1 = "UDF1",
                    UDF2 = "UDF2",
                    UDF3 = "UDF3",
                    UDF4 = "UDF4",
                    UDF5 = "UDF5"
                };


                throw new NotImplementedException();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<TaskDto> GetTasksByCategoryId(string categoryId)
        {
            try
            {

            throw new NotImplementedException();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<TaskDto> GetTasksByPriorityId(string priorityId)
        {
            try
            {

            throw new NotImplementedException();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<TaskDto> GetTasksByProjectId(string projectId)
        {
            try
            {
            throw new NotImplementedException();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<TaskDto> GetTasksByStatusId(string statusId)
        {
            try
            {

            throw new NotImplementedException();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<TaskDto> GetTasksByUserId(string userId)
        {
            try
            {

            throw new NotImplementedException();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public TaskDto CreateTask(TaskDto task)
        {
            try
            {

            throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TaskDto DeleteTask(string id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public TaskDto UpdateTask(TaskDto task)
        {
            try
            {

            throw new NotImplementedException();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
