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

        var claims = new List<Claim>
        {
            new Claim("FullName", user.FullName),
        };

        context.IssuedClaims.AddRange(claims);
    }

    public async Task IsActiveAsync(IsActiveContext context)
    {
        //>Processing
        var user = await _userManager.GetUserAsync(context.Subject);
        
        context.IsActive = (user != null) && true;//user.IsActive;
    }
}