using IdentityService.Models;
using SINNIKA.EFCore.Initialize;

namespace IdentityService.Infanstructure.Repositories
{
    public interface IUserRepository:IRepository<TblUser>
    {
    }
}