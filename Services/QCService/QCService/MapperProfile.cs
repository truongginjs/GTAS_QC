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
            CreateMap<QCRequestUpdateReqDTO, QCRequest>();
            CreateMap<QCRequest, QCRequestResDTO>();

            CreateMap<QCRequest, QCDetailResDTO>();//.ForMember(des=>des.DefectSizeBreakDown);

        }
    }
}