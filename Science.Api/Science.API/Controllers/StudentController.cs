using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Science.API.User.Login;
using Science.Service.IServices;

namespace Science.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            await studentService.Login(loginRequest);
        }
    }

}
