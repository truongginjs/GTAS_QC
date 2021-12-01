using IdentityService.Infrastructure.GTAS_PERMISSION.Models;
using SINNIKA.EFCore.Initialize;

namespace IdentityService.Infrastructure.Repositories
{
    public interface IRefeshTokenRepository : IRepository<TblRefreshToken>
    {
        bool RevokeToken(string refreshToken);
        bool CheckExist(string token);
        void UpdateRefreshToken(string oldToken, string newToken);

    }
}