﻿using AutoMapper;
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

        [HttpGet("getById")]
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

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            Log.Information("Ah, there you are!");
            return Ok(await studentService.GetAllAsync());
        }
    }

}
