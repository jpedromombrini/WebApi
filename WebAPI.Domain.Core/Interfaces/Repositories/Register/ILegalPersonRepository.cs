using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Models.Register;

namespace WebAPI.Domain.Core.Interfaces.Repositories.Register
{
    public interface ILegalPersonRepository : IBaseRepository<LegalPersonModel> 
    {
        Task<LegalPersonModel> GetByCnpjAsync(string cnpj);   
        Task<IEnumerable<LegalPersonModel>> GetByCompanyNameAsync(string companyName);     
    }
}