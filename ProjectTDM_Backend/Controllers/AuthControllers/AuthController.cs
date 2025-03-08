using Microsoft.AspNetCore.Mvc;
using TDM.Service.CustomDTOs;
using TDM.Service.Services.AuthService;

namespace ProjectTDM_API.Controllers.AuthControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly AuthServiceManager _authManager;
        public AuthController(AuthServiceManager authManager)
        {
            _authManager = authManager;
        }

        //[HttpPost]
        //public async Task<ActionResult> Login([FromBody] LoginDto loginDto)
        //{
        //    var userDto = await _authManager.Login(loginDto);
        //    if (userDto == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(userDto);
        //}
        [HttpPost]
        [Route("RegisterUser")]
        public async Task<ActionResult> RegisterUser([FromBody] RegisterDto registerDto)
        {
            var response = await _authManager.RegisterUser(registerDto);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
