using Science.Entity;

namespace Science.Data.IRepositories
{
    public interface IAdvisorRepository
    {
        Task CreateAsync(Advisor advisor);

        void Update(Advisor advisor);

        void Delete(Advisor advisor);

        Task<IEnumerable<Advisor>> GetAllAsync();

        Task<Advisor> GetByIdAsync(Guid id);
    }
}
