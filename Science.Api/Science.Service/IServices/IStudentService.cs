using Science.Entity;

namespace Science.Service.IServices
{
    public interface IStudentService
    {

        Task CreateAsync(Student student);

        void Update(Student student);

        Task<bool> Delete(Guid Id);

        Task<IEnumerable<Student>> GetAllAsync();

        Task<Student> GetByIdAsync(Guid id);

        Task SaveChangesAsync();
    }
}
