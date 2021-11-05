using AutoMapper;
using LibraryService.DTOs.Requests;
using LibraryService.DTOs.Responses;
using LibraryService.Heplers.Extensions;
using LibraryService.Models.L01;
using LibraryService.Models.DTOs;
using LibraryService.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json;

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
            // CreateMap<TestRequestDTO, Test>();
        }
        
    }
}