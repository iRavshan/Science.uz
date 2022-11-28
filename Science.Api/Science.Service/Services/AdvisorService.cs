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

        public AdvisorService()
        {
            this.advisorRepository = advisorRepository;
        }
        public async Task Create(Advisor advisor)
        {
            advisorRepository.Create(advisor);
        }

        public async Task Delete(Advisor advisor)
        {
            await advisorRepository.Delete(advisor);
        }

        public async Task<IEnumerable<Advisor>> GetAllAsync()
        {
            return await advisorRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Advisor>> GetById(Guid id)
        {
            return await advisorRepository.GetById(id);
        }

        public async Task Update(Advisor advisor)
        {
            return await advisorRepository.Update(advisor);
        }

        public async Task Login(LoginRequest loginRequest)
        {

        }
    }
}
