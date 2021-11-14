namespace IdentityService.Infanstructure.Services.Imps
{
    public class AppSettings
    {
        public static string Section = "AppSettings";
        public string JwtSecret { get; set; }
        //public string JwtValidIssuer { get; set; }
        //public string JwtValidAudience { get; set; }
        public string JwtIssuer { get; set; }
        public string JwtAudience { get; set; }
        public double JwtExpiryInMinutes { get; set; }
        public string RefreshTokenExpiryTimeInMinutes { get; set; }
        public string ConnectionString { get; set; }

    }
}