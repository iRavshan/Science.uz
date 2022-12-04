using Science.Entity;

namespace Science.Service.IServices
{
    public interface IWorkService
    {
        Task Create(Work work);

        void Delete(Work work);

        void Update(Work work);

        Task<IEnumerable<Work>> GetAllServiceAsync();

        Task<Work> GetByIdService(Guid id);
    }
}
