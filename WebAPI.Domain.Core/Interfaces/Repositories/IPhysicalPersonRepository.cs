using System.Threading.Tasks;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Core.Interfaces.Repositories
{
    public interface IPhysicalPersonRepository : IBaseRepository<PhysicalPersonModel>
    {
        Task<PhysicalPersonModel> GetByCpfAsync(string cpf);
    }
}