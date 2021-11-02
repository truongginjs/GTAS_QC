using IdentityService.Models;
using SINNIKA.EFCore.Initialize;

namespace IdentityService.Infanstructure.Repositories.Imps
{
    public class UserRepository : GenericRepository<TblUser>, IUserRepository
    {
        public UserRepository(GTAS_MENUContext context) : base(context)
        {
        }
    }
}
