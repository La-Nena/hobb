using HobApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HobApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            if (loginRequest.Email == "bobbo@bobbo.com" && loginRequest.Password == "bobba")
            {
                return Ok("YOU MADE IT!!!!");
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
