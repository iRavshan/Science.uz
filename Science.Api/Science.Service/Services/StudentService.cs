﻿using Science.Data.IRepositories;
using Science.DTO.Student;
using Science.Entity;
using Science.Service.IServices;

namespace Science.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public async Task CreateAsync(Student student)
        {
            await studentRepository.Create(student);
        }

        public async Task<bool> Delete(Guid Id)
        {
            var student = await studentRepository.GetById(Id);

            if(student == null) { return false; }

            studentRepository.Delete(student);

            return true;
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
           return await studentRepository.GetAllAsync();
        }

        public async Task<Student> GetByIdAsync(Guid id)
        {
            return await studentRepository.GetById(id);
        }

        public async Task SaveChangesAsync()
        {
            await studentRepository.SaveChangesAsync();
        }

        public void Update(Student student)
        {
            studentRepository.Update(student);
        }
    }
}
