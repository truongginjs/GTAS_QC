namespace IdentityService.DTOs.Requests
{
    public class RefreshTokenReqDTO
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}