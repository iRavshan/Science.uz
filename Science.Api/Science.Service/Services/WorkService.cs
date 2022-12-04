using Science.Data.IRepositories;
using Science.Entity;
using Science.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Service.Services
{
    public class WorkService : IWorkService
    {
        public readonly IWorkRepository workRepository;

        public WorkService(IWorkRepository workRepository)
        {
            this.workRepository = workRepository;
        }

        public async Task Create(Work work)
        {
            await workRepository.Create(work);
        }

        public void Delete(Work work)
        {
            workRepository.Delete(work);
        }

        public async Task<IEnumerable<Work>> GetAllServiceAsync()
        {
            return await workRepository.GetAllAsync();
        }

        public async Task<Work> GetByIdService(Guid id)
        {
            return await workRepository.GetById(id);
        }

        public void Update(Work work)
        {
            workRepository.Update(work);
        }
    }
}
