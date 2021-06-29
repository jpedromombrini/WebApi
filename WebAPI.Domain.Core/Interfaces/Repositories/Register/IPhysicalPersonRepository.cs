using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Models.Register;

namespace WebAPI.Domain.Core.Interfaces.Repositories.Register
{
    public interface IPhysicalPersonRepository : IBaseRepository<PhysicalPersonModel>
    {
        Task<PhysicalPersonModel> GetByCpfAsync(string cpf);
        Task<IEnumerable<PhysicalPersonModel>> GetByNameAsync(string name);
    }
}