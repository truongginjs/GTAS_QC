using IdentityService.DTOs;

namespace IdentityService.Infanstructure.Services
{
    public interface IAuthService
    {
        public void Login(UserLoginDTO user);
        public void Logout();
        public void Register();
    }
}