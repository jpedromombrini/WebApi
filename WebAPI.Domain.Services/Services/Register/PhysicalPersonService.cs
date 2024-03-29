using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Core.Interfaces.Repositories.Register;
using WebAPI.Domain.Core.Interfaces.Services.Register;
using WebAPI.Domain.Models.Register;

namespace WebAPI.Domain.Services.Services.Register
{
    public class PhysicalPersonService : BaseService<PhysicalPersonModel>, IPhysicalPersonService
    {
        private readonly IPhysicalPersonRepository _physicalPersonRepository;
        public PhysicalPersonService(IPhysicalPersonRepository physicalPersonRepository)
            :base(physicalPersonRepository)
        {
            _physicalPersonRepository = physicalPersonRepository;
        }

        public async Task<PhysicalPersonModel> GetByCpfAsync(string cpf)
        {
            return await _physicalPersonRepository.GetByCpfAsync(cpf);
        }

        public async Task<IEnumerable<PhysicalPersonModel>> GetByNameAsync(string name)
        {
            return await _physicalPersonRepository.GetByNameAsync(name);
        }
    }
}