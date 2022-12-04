using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Science.DTO.Student;
using Science.Entity;
using Science.Service.IServices;

namespace Science.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudentService studentService;
        private readonly IMapper mapper;

        public StudentController(IStudentService studentService,
                                 IMapper mapper)
        {
            this.studentService = studentService;
            this.mapper = mapper;
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var student = await studentService.GetByIdAsync(Id);

            return Ok(student);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(StudentCreationDto student)
        {
            await studentService.CreateAsync(mapper.Map<Student>(student));

            await studentService.SaveChangesAsync();

            return Ok();
        }
    }

}
