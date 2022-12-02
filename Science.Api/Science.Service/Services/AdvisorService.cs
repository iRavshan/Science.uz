using Science.Data.IRepositories;
using Science.DTO.User.Login;
using Science.Entity;
using Science.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Service.Services
{
    public class AdvisorService : IAdvisorService
    {
        public readonly IAdvisorRepository advisorRepository;

        public AdvisorService(IAdvisorRepository advisorRepository)
        {
            this.advisorRepository = advisorRepository;
        }
        public async Task Create(Advisor advisor)
        {
            await advisorRepository.CreateAsync(advisor);
        }

        public async Task Delete(Advisor advisor)
        {
            await advisorRepository.DeleteAsync(advisor);
        }

        public async Task<IEnumerable<Advisor>> GetAllAsync()
        {
            return await advisorRepository.GetAllAsync();
        }

        public async Task<Advisor> GetById(Guid id)
        {
            return await advisorRepository.GetByIdAsync(id);
        }

        public void Update(Advisor advisor)
        {
            advisorRepository.Update(advisor);
        }
    }
}
