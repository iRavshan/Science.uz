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
    public class AdvisorRepository : IAdvisorRepository
    {
        private readonly AppDbContext dbContext;

        public AdvisorRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Create(Advisor advisor)
        {
            await dbContext.Advisors.AddAsync();
        }

        public async Task Delete(Advisor advisor)
        {
            dbContext.Advisors.Remove(advisor);
        }

        public async Task<IEnumerable<Advisor>> GetAllAsync()
        {
            return await dbContext.Advisors.ToListAsync();
        }

        public async Task<Advisor> GetById(Guid id)
        {
            return await dbContext.Advisors.FirstOrDefaultAsync(advisor => advisor.Id == id);
        }

        public void Update(Advisor advisor)
        {
            dbContext.Advisors.Update(advisor);
        }
    }
}
