using Microsoft.EntityFrameworkCore;
using Science.Data.DataContexts;
using Science.Data.IRepositories;
using Science.Entity;

namespace Science.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public readonly AppDbContext dbContext;

        public StudentRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Create(Student student)
        {
            await dbContext.Students.AddAsync(student);
        }

        public void Delete(Student student)
        {
            dbContext.Students.Remove(student);
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await dbContext.Students.ToListAsync();
        }

        public async Task<Student?> GetById(Guid id)
        {
            return await dbContext.Students.FirstOrDefaultAsync(student => student.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public void Update(Student student)
        {
            dbContext.Students.Update(student);
        }
    }
}
