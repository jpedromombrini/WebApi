using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Core.Interfaces.Services;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Services.Services
{
    public class PhysicalPersonService : BaseService<PhysicalPersonModel>, IPhysicalPersonService
    {
        private readonly IPhysicalPersonRepository _physicalPersonRepository;
        public PhysicalPersonService(IPhysicalPersonRepository physicalPersonRepository)
            :base(physicalPersonRepository)
        {
            _physicalPersonRepository = physicalPersonRepository;
        }
    }
}