using Science.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Service.IServices
{
    public interface IWorkService
    {
        Task Create(Work work);

        Task Delete(Work work);

        void Update(Work work);

        Task<IEnumerable<Work>> GetAllServiceAsync();

        Task<Work> GetByIdService(Guid id);
    }
}
