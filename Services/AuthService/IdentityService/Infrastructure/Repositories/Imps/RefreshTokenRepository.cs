using System.Linq;
using IdentityService.Infrastructure.GTAS_MENU;
using IdentityService.Infrastructure.GTAS_PERMISSION;
using IdentityService.Infrastructure.GTAS_PERMISSION.Models;
using Microsoft.EntityFrameworkCore;
using SINNIKA.EFCore.Initialize;

namespace IdentityService.Infrastructure.Repositories.Imps
{

    public class RefreshTokenRepository : GenericRepository<TblRefreshToken>, IRefeshTokenRepository
    {
        private readonly GTAS_PERMISSIONContext _context;
        private readonly DbSet<TblRefreshToken> _table;

        public RefreshTokenRepository(GTAS_PERMISSIONContext context) : base(context)
        {
            _context = context;
            _table = context.RefreshToken;
        }

        public bool RevokeToken(string refreshToken)
        {
            var data = _table.AsNoTracking().Where(x => x.RefreshToken.Equals(refreshToken));
            var result = _table.Remove(data.FirstOrDefault());
            _context.SaveChanges();
            return result.State == EntityState.Detached;
        }

        public bool CheckExist(string token)
        {
            return _table.Where(x => x.RefreshToken.Equals(token)).Count() > 0;
        }

        public void UpdateRefreshToken(string oldToken, string newToken)
        {
            var data = _table.Where(x => x.RefreshToken.Equals(oldToken)).FirstOrDefault();
            if (data != null)
            {
                data.RefreshToken = newToken;
                _context.SaveChangesAsync();
            }
        }

    }
}