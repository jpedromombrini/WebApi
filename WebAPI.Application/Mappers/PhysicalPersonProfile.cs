using AutoMapper;
using WebAPI.Application.DTO.Requests;
using WebAPI.Application.DTO.Responses;
using WebAPI.Domain.Models;

namespace WebAPI.Application.Mappers
{
    public class PhysicalPersonProfile : Profile
    {
        public PhysicalPersonProfile()
        {
            CreateMap<PhysicalPersonModel, PhysicalPersonResponse>();
            CreateMap<CreatePhysicalPersonRequest, PhysicalPersonModel>();
        }
    }
}