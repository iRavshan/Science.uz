using Science.Data.IRepositories;
using Science.Entity;
using Science.Service.IServices;

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

        public void Delete(Advisor advisor)
        {
            advisorRepository.Delete(advisor);
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
