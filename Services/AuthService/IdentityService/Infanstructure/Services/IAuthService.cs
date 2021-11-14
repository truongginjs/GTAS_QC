using IdentityService.DTOs;
using IdentityService.DTOs.Requests;
using IdentityService.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdentityService.Infanstructure.Services
{
    public interface IAuthService
    {
        UserResDTO Login(UserLoginReqDTO UserForm, out string message);
        bool Logout();
        UserResDTO RefreshToken(string refreshToken, out string message);
    }
}