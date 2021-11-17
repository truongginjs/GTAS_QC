using AutoMapper;
using QCService.DTOs.Requests;
using QCService.DTOs.Responses;
using QCService.Helpers.Extensions;
using QCService.Models.D01;
using QCService.Models.Enums;

namespace QCService
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // CreateMap<TestRequestDTO, Test>();

            CreateMap<QCRequestCreateResDTO, QCRequest>();
            CreateMap<QCRequestUpdateReqDTO, QCRequest>();

            CreateMap<QCRequest, QCDetailResDTO>();//.ForMember(des=>des.DefectSizeBreakDown);

            CreateMap<QCRequestResDBDTO, QCRequestResDTO>()
                .ForMember(des => des.TransferStatus,
                act => act.MapFrom(src => src.TransferStatus.ToString()))
                .ForMember(des => des.DocStatus,
                act => act.MapFrom(src => src.DocStatus.ToString()));

            CreateMap<QCRequestDetailResDBDTO, QCRequestDetailResDTO>()
                .ForMember(des => des.TransferStatus,
                act => act.MapFrom(src => src.TransferStatus.ToString()))
                .ForMember(des => des.DocStatus,
                act => act.MapFrom(src => src.DocStatus.ToString()));

            CreateMap<QCRequestDetailReqDBDTO, QCRequestDetailReqDTO>()
                .ForMember(des => des.TransferStatus,
                act => act.MapFrom(src => src.TransferStatus.ToString()))
                .ForMember(des => des.DocStatus,
                act => act.MapFrom(src => src.DocStatus.ToString()));

            CreateMap<QCRequestDetailReqDTO, QCRequestDetailReqDBDTO>()
                .ForMember(des => des.TransferStatus,
                act => act.MapFrom(src => src.TransferStatus.ToEnum(TransferStatusEnum.NotTransfered)))
                .ForMember(des => des.DocStatus,
                act => act.MapFrom(src => src.DocStatus.ToEnum(DocStatusEnum.Inprogress)));
        }
    }
}