using Science.Entity;

namespace Science.Service.IServices
{
    public interface IAdvisorService
    {

        Task Create(Advisor advisor);

        void Update(Advisor advisor);

        void Delete(Advisor advisor);

        Task<IEnumerable<Advisor>> GetAllAsync();

        Task<Advisor> GetById(Guid id);
    }
}
