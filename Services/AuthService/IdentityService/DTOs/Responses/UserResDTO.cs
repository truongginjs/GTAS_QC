using System;

namespace IdentityService.DTOs.Responses
{
    public class UserResDTO
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public PermissionResDTO Permission { get; set; }
    }
}