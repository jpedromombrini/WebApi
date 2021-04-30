using System.Threading.Tasks;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Core.Interfaces.Services.Register
{
    public interface IPhysicalPersonService : IBaseService<PhysicalPersonModel> 
    {
        Task<PhysicalPersonModel> GetByCpfAsync(string cpf);
    }
}