using AutoMapper;
using LibraryService.DTOs.Requests;
using LibraryService.DTOs.Responses;
using LibraryService.Heplers.Extensions;
using LibraryService.Models.L01;
using LibraryService.Models.DTOs;
using LibraryService.Models.Enums;

namespace LibraryService
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region zonetype
            CreateMap<QCZoneTypeLib, QCZoneTypeResDTO>()
                .ForMember(des => des.GroupType,
                act => act.MapFrom(src => src.GroupType.ToString()));

            CreateMap<FormLibDTO, FormLibResDTO>()
                .ForMember(des => des.FormType,
                act => act.MapFrom(src => src.FormType.ToString()));

            CreateMap<QCZoneTypeReqDTO, QCZoneTypeLib>()
                .ForMember(des => des.GroupType,
                act => act.MapFrom(src => src.GroupType.ToEnum(QCZoneTypeGroupEnum.Unknown)));

            CreateMap<FormLibReqDTO, FormLibDTO>()
               .ForMember(des => des.FormType,
               act => act.MapFrom(src => src.FormType.ToEnum(FormEnum.Unknown)));
            #endregion

            #region AQL
            CreateMap<AQLLib, AQLResDTO>();
            CreateMap<AQLReqDTO, AQLLib>();
            #endregion

            #region Defect
            CreateMap<DefectLib, DefectResDTO>();
            CreateMap<DefectReqDTO, DefectLib>();
            #endregion

            #region Handler
            CreateMap<HandlerDefectLib, HandlerDefectResDTO>();
            CreateMap<HandlerDefectReqDTO, HandlerDefectLib>();
            #endregion

            #region Time
            CreateMap<TimeDefectLib, TimeDefectResDTO>();
            CreateMap<TimeDefectReqDTO, TimeDefectLib>();
            #endregion

            #region Site
            CreateMap<SiteLib, SiteResDTO>();
            CreateMap<SiteReqDTO, SiteLib>();
            #endregion
        }

    }
}