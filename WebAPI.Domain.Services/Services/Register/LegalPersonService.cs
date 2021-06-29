using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Core.Interfaces.Repositories.Register;
using WebAPI.Domain.Core.Interfaces.Services.Register;
using WebAPI.Domain.Models.Register;

namespace WebAPI.Domain.Services.Services.Register
{
    public class LegalPersonService : BaseService<LegalPersonModel>, ILegalPersonService
    {
        private readonly ILegalPersonRepository _legalPersonRepository;
        public LegalPersonService(ILegalPersonRepository legalPersonRepository)
            :base(legalPersonRepository)
        {
            _legalPersonRepository = legalPersonRepository;
        }       
        public async Task<LegalPersonModel> GetByCnpjAsync(string cnpj)
        {
            return await _legalPersonRepository.GetByCnpjAsync(cnpj);
        }

        public async Task<IEnumerable<LegalPersonModel>> GetByCompanyNameAsync(string companyName)
        {
            return await _legalPersonRepository.GetByCompanyNameAsync(companyName);
        }
    }
}