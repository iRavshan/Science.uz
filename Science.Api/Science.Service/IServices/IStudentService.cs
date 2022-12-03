using Science.Entity;

namespace Science.Service.IServices
{
    public interface IStudentService
    {

        Task Create(Student student);

        void Update(Student student);

        Task Delete(Student student);

        Task<IEnumerable<Student>> GetAllAsync();

        Task<Student> GetByServiesId(Guid id);
    }
}
