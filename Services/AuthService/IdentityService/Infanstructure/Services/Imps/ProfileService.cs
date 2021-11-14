using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Services;
using IdentityService.Models;
using Microsoft.AspNetCore.Identity;

public class ProfileService : IProfileService
{
    protected UserManager<TblUser> _userManager;

    public ProfileService(UserManager<TblUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task GetProfileDataAsync(ProfileDataRequestContext context)
    {
        //>Processing
        var user = await _userManager.GetUserAsync(context.Subject);

        var claims = GetClaims(user);

        context.IssuedClaims.AddRange(claims);
    }


    public async Task IsActiveAsync(IsActiveContext context)
    {
        //>Processing
        var user = await _userManager.GetUserAsync(context.Subject);
        
        context.IsActive = (user != null) && true;//user.IsActive;
    }
    private List<Claim> GetClaims(TblUser user)
        {
            var claims = new List<Claim> {
                            new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                            new Claim(ClaimTypes.Name, user.FullName??"null"),
                            new Claim(ClaimTypes.Email, user.EmailAddress1??"null"),
                        };
            return claims;
        }
}