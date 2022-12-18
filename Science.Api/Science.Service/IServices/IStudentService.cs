using Science.Entity;

namespace Science.Service.IServices
{
    public interface IStudentService
    {
        Task<Student> CreateAsync(Student student);

        Student Update(Student student);

        Task<bool> DeleteAsync(Guid Id);

        Task<IEnumerable<Student>> GetAllAsync();

        Task<Student> GetByIdAsync(Guid id);

        Task SaveChangesAsync();
    }
}
