using Microsoft.EntityFrameworkCore;
using Science.Data.DataContexts;
using Science.Data.IRepositories;
using Science.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public readonly AppDbContext dbContext;

        public StudentRepository(AppDbContext appContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Create(Student student)
        {
            await dbContext.Students.AddAsync(student);
        }

        public async Task Delete(Student student)
        {
            await dbContext.Students.Remove(student);
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await dbContext.Students.ToListAsync();
        }

        public async Task<Student> GetById(Guid id)
        {
            return await dbContext.Students.FirstOrDefaultAsync(student => student.Id == id);
        }

        public void Update(Student student)
        {
            dbContext.Students.Update(student);
        }
    }
}
