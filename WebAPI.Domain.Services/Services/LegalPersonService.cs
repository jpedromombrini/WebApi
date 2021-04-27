using System.Threading.Tasks;
using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Core.Interfaces.Services;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Services.Services
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
    }
}