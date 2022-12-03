using Science.Entity;

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
