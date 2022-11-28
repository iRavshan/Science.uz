using Science.
using Science.DTO.User.Login;
using Science.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Service.IServices
{
    public interface IStudentService
    {

        Task Create(Student student);

        Task Update(Student student);

        Task Delete(Student student);

        Task<IEnumerable<Student>> GetAllAsync();

        Task<Student> GetByServiesId(Guid id);

        Task Login(LoginRequest loginRequest);
    }
}
