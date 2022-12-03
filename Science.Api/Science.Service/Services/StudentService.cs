using Science.Data.IRepositories;
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

        public void Update(Student student)
        {
            studentRepository.Update(student);
        }
    }
}
