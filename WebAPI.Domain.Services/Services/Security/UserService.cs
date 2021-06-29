using WebAPI.Domain.Core.Interfaces.Repositories.Security;
using WebAPI.Domain.Models.Security;

namespace WebAPI.Domain.Services.Services.Security
{
    public class UserService : BaseService<UserModel>
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }
        
    }
}