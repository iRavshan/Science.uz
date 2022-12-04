using Microsoft.EntityFrameworkCore;
using Science.Data.DataContexts;
using Science.Data.IRepositories;
using Science.Entity;

namespace Science.Data.Repositories
{
    public class WorkRepository : IWorkRepository
    {
        public readonly AppDbContext dbContext;

        public WorkRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext; 
        }

        public async Task Create(Work work)
        {
           await dbContext.Works.AddAsync(work);
        }

        public void Delete(Work work)
        {
            dbContext.Works.Remove(work);
        }

        public async Task<IEnumerable<Work>> GetAllAsync()
        {
            return await dbContext.Works.ToListAsync();
        }

        public async Task<Work?> GetById(Guid id)
        {
            return await dbContext.Works.FirstOrDefaultAsync(work => work.Id == id);
        }

        public void Update(Work work)
        {
            dbContext.Works.Update(work);
        }
    }
}
