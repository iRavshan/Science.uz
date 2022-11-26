using Science.Data.DataContexts;
using Science.Data.IRepositories;
using Science.Entity;

namespace Science.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext dbContext;

        public StudentRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Create(Student student)
        {
            await dbContext.Students.AddAsync(student);
        }

        public async Task Delete(Student student)
        {
            dbContext.Students.Remove(student);
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Student> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
