using Science.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Data.IRepositories
{
    public interface IWorkRepository
    {
        Task Create(Work work);

        Task Delete(Work work);

        void Update(Work work);

        Task<IEnumerable<Work>> GetAllAsync();

        Task<Work> GetById(Guid id);
    }
}
