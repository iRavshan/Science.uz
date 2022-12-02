using Microsoft.AspNetCore.Mvc;
using Science.Service.IServices;
using Serilog;

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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            Log.Information("GetAll ishladi");

            return Ok(await studentService.GetAllAsync());
        }
    }

}
