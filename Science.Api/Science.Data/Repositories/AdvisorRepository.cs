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

        public Task Create(Advisor advisor)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Advisor advisor)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Advisor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Advisor> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Advisor advisor)
        {
            throw new NotImplementedException();
        }
    }
}
