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
    public class WorkRepository : IWorkRepository
    {
        public readonly AppDbContext dbContext;

        public WorkRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext; 
        }

        public async Task Create(Work work)
        {
           return await dbContext.Works.AddAsync(work);
        }

        public async Task Delete(Work work)
        {
            await dbContext.Works.Remove(work);
        }

        public async Task<IEnumerable<Work>> GetAllAsync()
        {
            return await dbContext.Works.ToListAsync();
        }

        public async Task<Work> GetById(Guid id)
        {
            return await dbContext.Works.FirstOrDefaultAsync(work => work.Id == id);
        }

        public void Update(Work work)
        {
            dbContext.Works.Update(work);
        }
    }
}
