using Science.Data.IRepositories;
using Science.DTO.User.Login;
using Science.Entity;
using Science.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public async Task Create(Student student)
        {
            await studentRepository.Create(student);
        }

        public async Task Delete(Student student)
        {
            await studentRepository.Delete(student);
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
           return await studentRepository.GetAllAsync();
        }

        public async Task<Student> GetByServiesId(Guid id)
        {
            return await studentRepository.GetById(id);
        }

        public async Task Update(Student student)
        {
           return await studentRepository.Update(student);
        }
    }
}
