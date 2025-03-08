using Microsoft.AspNetCore.Mvc;
using TDM.Service.DTOs;
using TDM.Service.Services.UserServices;

namespace ProjectTDM_API.Controllers.UserControllers
{
    public class UserController : Controller
    {
        private UserManager _userManager;
        public UserController( UserManager userManager)
        {
            this._userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/GetUserByUserId/{userId}")]
        public async Task<ActionResult<UserDto>>  GetUserById([FromRoute] int userId)
        {
            var userDto = await _userManager.GetUserDto(userId);
            if(userDto==null)
            {
                return NotFound();
            }
            return Ok(userDto);
        }
    }
}
