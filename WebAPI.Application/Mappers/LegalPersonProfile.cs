using AutoMapper;
using WebAPI.Application.DTO.Requests.Register;
using WebAPI.Application.DTO.Responses.Register;
using WebAPI.Domain.Models;

namespace WebAPI.Application.Mappers
{
    public class LegalPersonProfile : Profile
    {
        public LegalPersonProfile()
        {
            CreateMap<LegalPersonModel, LegalPersonResponse>();
            CreateMap<CreateLegalPersonRequest, LegalPersonModel>();   
            CreateMap<UpdateLegalPersonRequest, LegalPersonModel>()
                .ReverseMap();                
        }
    }
}