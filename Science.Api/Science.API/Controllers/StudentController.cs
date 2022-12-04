using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Science.DTO.Student;
using Science.Entity;
using Science.Service.IServices;
using Serilog;

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

            //var StudentDto = mapper.Map<StudentDto>(student); //mapping

            return Ok(student);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(StudentCreationDto student)
        {
            Student newStudent = new Student
            {
                Id = student.Id,
                FirstName = student.Firstname,
                LastName = student.Lastname,
                PhoneNumber = string.Empty
            };
            
            await studentService.CreateAsync(newStudent);

            await studentService.SaveChangesAsync();

            return Ok();
        }
    }

}
