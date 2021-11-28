using AutoMapper;
using LibraryService.DTOs.Requests;
using LibraryService.DTOs.Responses;
using LibraryService.Heplers.Extensions;
using LibraryService.Models.L01;
using LibraryService.Models.DTOs;
using LibraryService.Models.Enums;
using System.Linq;

using Lan = LibraryService.Heplers.Constants.MyConstants.LanguageConstants;
using DSSType = System.Collections.Generic.Dictionary<string, string>;

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
            CreateMap<DefectLib, DefectResDTO>()
                 .ForMember(des => des.DefectTypes,
                        act => act.MapFrom(src => src.DefectTypes.Select(x=>x[Lan.En]).ToList()))
                 .ForMember(des => des.Reasons,
                        act => act.MapFrom(src => src.Reasons.Select(x=>x[Lan.En]).ToList()))
                 .ForMember(des => des.Solutions,
                        act => act.MapFrom(src => src.Solutions.Select(x => x[Lan.En]).ToList()));

            CreateMap<DefectReqDTO, DefectLib>()
                .ForMember(des => des.DefectTypes,
                        act => act.MapFrom(src => src.DefectTypes.Select(x => new DSSType { { Lan.Vi ,string.Empty},{ Lan.En,x} }).ToList()))
                 .ForMember(des => des.Reasons,
                        act => act.MapFrom(src => src.Reasons.Select(x => new DSSType { { Lan.Vi, string.Empty }, { Lan.En, x } }).ToList()))
                 .ForMember(des => des.Solutions,
                        act => act.MapFrom(src => src.Solutions.Select(x => new DSSType { { Lan.Vi, string.Empty }, { Lan.En, x } }).ToList()));
            #endregion

            #region Handler
            CreateMap<HandlerDefectLib, HandlerDefectResDTO>();
            CreateMap<HandlerDefectReqDTO, HandlerDefectLib>();
            #endregion

            #region Time
            CreateMap<TimelineDefectLib, TimelineDefectResDTO>();
            CreateMap<TimelineDefectReqDTO, TimelineDefectLib>();
            #endregion

            #region Site
            CreateMap<SiteLib, SiteResDTO>();
            CreateMap<SiteReqDTO, SiteLib>();
            #endregion


            #region Department
            CreateMap<DepartmentLib, DepartmentResDTO>();
            CreateMap<DepartmentReqDTO, DepartmentLib>();
            #endregion

            #region Cutting table
            CreateMap<CuttingTableLib, CuttingTableResDTO>();
            CreateMap<CuttingTableReqDTO, CuttingTableLib>();
            #endregion
        }

    }
}