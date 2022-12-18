using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Science.API.Helpers.IServices;

namespace Science.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IPasswordManager passwordManager;
        private readonly IJwtManager jwtManager;

        public AuthController(IPasswordManager passwordManager,
                              IJwtManager jwtManager)
        {
            this.passwordManager = passwordManager;
            this.jwtManager = jwtManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {
            return Ok(jwtManager.CreateToken());
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login()
        {
            return Ok();
        }
    }
}
