using Science.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Data.IRepositories
{
    public interface IAdvisorRepository
    {
        Task Create(Advisor advisor);
        Task Update(Advisor advisor);
        Task Delete(Advisor advisor);
        Task<IEnumerable<Advisor>> GetAllAsync();
        Task<Advisor> GetById(Guid id);
    }
}
