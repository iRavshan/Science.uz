using Science.DTO.User.Login;
using Science.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Service.IServices
{
    public interface IAdvisorService
    {

        Task Create(Advisor advisor);

        void Update(Advisor advisor);

        Task Delete(Advisor advisor);

        Task<IEnumerable<Advisor>> GetAllAsync();

        Task<Advisor> GetById(Guid id);
    }
}
