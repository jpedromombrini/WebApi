using System.Threading.Tasks;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Core.Interfaces.Services
{
    public interface ILegalPersonService : IBaseService<LegalPersonModel> 
    {
        Task<LegalPersonModel> GetByCnpjAsync(string cnpj);
    }
}