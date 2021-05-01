using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Core.Interfaces.Services.Register
{
    public interface ILegalPersonService : IBaseService<LegalPersonModel> 
    {
        Task<LegalPersonModel> GetByCnpjAsync(string cnpj);   
        Task<IEnumerable<LegalPersonModel>> GetByCompanyNameAsync(string companyName);          

    }
}