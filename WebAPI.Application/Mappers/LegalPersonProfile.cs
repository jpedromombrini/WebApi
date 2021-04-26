using AutoMapper;
using WebAPI.Application.DTO.Requests;
using WebAPI.Application.DTO.Responses;
using WebAPI.Domain.Models;

namespace WebAPI.Application.Mappers
{
    public class LegalPersonProfile : Profile
    {
        public LegalPersonProfile()
        {
            CreateMap<LegalPersonModel, LegalPersonResponse>();
            CreateMap<CreateLegalPersonRequest, LegalPersonModel>();                
        }
    }
}