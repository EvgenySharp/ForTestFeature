using Auth.BuisnessLayer;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        [Route("login")]
        public async Task<IActionResult> LoginАsync(LoginUserRequestDto loginRequestDto, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
    