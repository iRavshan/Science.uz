using Science.Entity;

namespace Science.Data.IRepositories
{
    public interface IStudentRepository
    {
        Task Create(Student student);

        void Update(Student student);

        void Delete(Student student);

        Task<IEnumerable<Student>> GetAllAsync();   
        
        Task<Student> GetById(Guid id);


    }
}
