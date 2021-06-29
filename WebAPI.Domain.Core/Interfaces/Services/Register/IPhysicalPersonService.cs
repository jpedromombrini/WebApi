using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Models.Register;

namespace WebAPI.Domain.Core.Interfaces.Services.Register
{
    public interface IPhysicalPersonService : IBaseService<PhysicalPersonModel> 
    {
        Task<PhysicalPersonModel> GetByCpfAsync(string cpf);
        Task<IEnumerable<PhysicalPersonModel>> GetByNameAsync(string name);
    }
}