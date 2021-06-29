using WebAPI.Domain.Models.Security;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repository.Repositories.Security
{
    public class UserRepository : BaseRepository<UserModel>
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}