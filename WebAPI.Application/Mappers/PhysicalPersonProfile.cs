using AutoMapper;
using WebAPI.Application.DTO.Requests.Register;
using WebAPI.Application.DTO.Responses.Register;
using WebAPI.Domain.Models;

namespace WebAPI.Application.Mappers
{
    public class PhysicalPersonProfile : Profile
    {
        public PhysicalPersonProfile()
        {
            CreateMap<PhysicalPersonModel, PhysicalPersonResponse>();
            CreateMap<CreatePhysicalPersonRequest, PhysicalPersonModel>();
            CreateMap<UpdatePhysicalPersonRequest, PhysicalPersonModel>()
                .ReverseMap();
        }
    }
}