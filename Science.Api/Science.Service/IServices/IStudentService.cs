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
    }
}
