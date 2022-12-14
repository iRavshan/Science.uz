using Microsoft.EntityFrameworkCore;
using Science.Data.DataContexts;
using Science.Data.IRepositories;
using Science.Entity;

namespace Science.Data.Repositories
{
    public class AdvisorRepository : IAdvisorRepository
    {
        private readonly AppDbContext dbContext;

        public AdvisorRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(Advisor advisor)
        {
            await dbContext.Advisors.AddAsync(advisor);
        }

        public void Delete(Advisor advisor)
        {
            dbContext.Advisors.Remove(advisor);
        }

        public async Task<IEnumerable<Advisor>> GetAllAsync()
        {
            return await dbContext.Advisors.ToListAsync();
        }

        public async Task<Advisor?> GetByIdAsync(Guid id)
        {
            return await dbContext.Advisors.FirstOrDefaultAsync(advisor => advisor.Id == id);
        }

        public void Update(Advisor advisor)
        {
            dbContext.Advisors.Update(advisor);
        }
    }
}
