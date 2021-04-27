using System.Threading.Tasks;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Core.Interfaces.Repositories
{
    public interface ILegalPersonRepository : IBaseRepository<LegalPersonModel> 
    {
        Task<LegalPersonModel> GetByCnpjAsync(string cnpj);
    }
}