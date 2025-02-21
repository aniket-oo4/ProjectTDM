using Microsoft.AspNetCore.Mvc;
using TDM.Service.DTOs;
using TDM.Service.Services.RoleServices;

namespace ProjectTDM_API.Controllers.UserRolesControllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRolesController : Controller
    {
        private readonly RoleManager _roleService;

        public UserRolesController(RoleManager roleService)
        {
            _roleService = roleService;
        }
        [HttpGet]
        [Route("api/GetRoleByUserId/{userId}")]
        public ActionResult <RoleDto> GetRoleById([FromRoute]int userId)
        {
            var roleDto = _roleService.GetRoleDto(userId);
            return roleDto;
        }

        //public ActionResult GetRole(RoleDto roleDto)
        //{
        //    var role = _roleService.GetRole(roleDto);
        //    return Ok(role);
        //}
    }
}
