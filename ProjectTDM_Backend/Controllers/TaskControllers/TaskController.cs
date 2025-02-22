using Microsoft.AspNetCore.Mvc;
using TDM.Service.DTOs;
using TDM.Service.Services.TaskServices;
namespace ProjectTDM_API.Controllers.TaskControllers
{

    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private readonly TaskManager _taskManager;
        public TaskController(TaskManager taskService) {
            _taskManager = taskService;
        }

        [HttpGet]
        [Route("api/GetTaskById/{id}")]
        public async Task<ActionResult<TaskDto>> GetTaskById([FromRoute]string id)
        {
            return _taskManager.GetTaskById(id);
            return View();
        }

    }
}
