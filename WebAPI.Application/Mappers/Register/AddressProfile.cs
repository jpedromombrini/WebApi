using AutoMapper;
using WebAPI.Application.DTO.Requests.Register;
using WebAPI.Application.DTO.Responses.Register;
using WebAPI.Domain.Models.Register;

namespace WebAPI.Application.Mappers.Register
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressModel, AddressResponse>();
            CreateMap<CreateAddressRequest, AddressModel>();
            CreateMap<UpdateAddressRequest, AddressModel>()
                .ReverseMap();
        }
    }
}