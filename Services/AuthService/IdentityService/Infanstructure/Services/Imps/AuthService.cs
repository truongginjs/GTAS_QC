using IdentityService.DTOs;
using IdentityService.Infanstructure.Repositories;
using IdentityService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Infanstructure.Services.Imps
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _repo;

        public AuthService(IUserRepository repo)
        {
            _repo = repo;
        }

        public async void Login(UserLoginDTO userInput)
        {
            Func<DbSet<TblUser>,Task< TblUser>> func = entity => entity.Where(x => x.UserLogin == userInput.Username && x.PasswordChar==userInput.Password).FirstOrDefaultAsync();
            var user = await _repo.InvokeAsync(func);
            if (user != null)
            {

            }
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            throw new NotImplementedException();
        }
    }
}
