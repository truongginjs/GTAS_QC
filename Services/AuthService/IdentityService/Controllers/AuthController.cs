using IdentityService.DTOs.Requests;
using IdentityService.DTOs.Responses;
using IdentityService.Infanstructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [AllowAnonymous]
        [HttpPost]
        public UserResDTO Login([FromBody] UserLoginReqDTO user)
        {
            var data = _authService.Login(user, out string message);
            data.Message = message;
            return data;
        }

        [HttpPost]
        public bool Logout()
        {
            var data = _authService.Logout();
            return data;
        }
        [HttpPost]
        public UserResDTO RefreshToken(string refreshToken)
        {
            var data = _authService.RefreshToken(refreshToken, out string message);
            return data;
        }

    }
}
