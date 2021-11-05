using AutoMapper;
using QCService.DTOs.Requests;
using QCService.DTOs.Responses;
using QCService.Models.D01;

namespace QCService
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // CreateMap<TestRequestDTO, Test>();

            CreateMap<QCRequestCreateResDTO, QCRequest>();
            CreateMap<QCRequestUpdateResDTO, QCRequest>();
            CreateMap<QCRequest, QCRequestResDTO>();

            CreateMap<QCTicketResDTO, QCTicket>()
                .ForMember(x => x.Id, act => act.MapFrom(des => des.QCTicketId));
        }
    }
}