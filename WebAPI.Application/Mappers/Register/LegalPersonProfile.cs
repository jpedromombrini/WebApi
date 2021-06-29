using AutoMapper;
using WebAPI.Application.DTO.Requests.Register;
using WebAPI.Application.DTO.Responses.Register;
using WebAPI.Domain.Models.Register;

namespace WebAPI.Application.Mappers.Register
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