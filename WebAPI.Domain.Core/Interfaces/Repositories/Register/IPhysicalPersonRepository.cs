using System.Threading.Tasks;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Core.Interfaces.Repositories.Register
{
    public interface IPhysicalPersonRepository : IBaseRepository<PhysicalPersonModel>
    {
        Task<PhysicalPersonModel> GetByCpfAsync(string cpf);
    }
}