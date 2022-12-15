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

        [HttpGet("getById/{id}")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var student = await studentService.GetByIdAsync(Id);

            if (student == null)
            {
                Log.Information("rasvo bo'ldi");

                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(StudentCreationDto student)
        {
            var newStudent = await studentService.CreateAsync(mapper.Map<Student>(student));

            if (newStudent == null)
            {
                return BadRequest();
            }

            await studentService.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            //Log.Information("Studentlar ro'yxati olindi");

            IEnumerable<Student> students = await studentService.GetAllAsync();

            if(students == null)
            {
                return NotFound();
            }

            return Ok(students);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid Id)
        {
            bool checker =  await studentService.DeleteAsync(Id);

            if(checker == false) 
            {
                return NotFound();
            }

            await studentService.SaveChangesAsync();

            return Ok();
        }
    }

}
