using System;
using System.Collections.Generic;
using IdentityService.DTOs.Requests;
using IdentityService.DTOs.Responses;

namespace IdentityService.Infrastructure.Services
{
    public interface IAuthService
    {
        UserResDTO Login(UserLoginReqDTO UserForm, out string message);
        bool RevokeToken(string refreshToken, out string message);
        UserResDTO RefreshToken(string refreshToken, string oldToken, out string message);
        UserResDTO Register(UserRegisterReqDTO registerUser, out string message);
        bool CheckPermisionOfUser(IEnumerable<string> permisions, string param);
        Guid? ValidateToken(string token);
    }
}