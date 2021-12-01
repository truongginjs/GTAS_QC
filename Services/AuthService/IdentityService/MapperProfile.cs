using AutoMapper;
using IdentityService.Infrastructure.GTAS_MENU.Models;
using IdentityService.Infrastructure.GTAS_PERMISSION.Models;

namespace IdentityService
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region zonetype
            CreateMap<TblUser, User>()
                .ForMember(des => des.Email,
                act => act.MapFrom(src => src.EmailAddress1))
                .ForMember(des => des.Username,
                act => act.MapFrom(src => src.UserLogin));

            #endregion
        }

    }
}