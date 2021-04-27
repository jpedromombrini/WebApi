using AutoMapper;
using WebAPI.Application.DTO.Requests;
using WebAPI.Application.DTO.Responses;
using WebAPI.Domain.Models;

namespace WebAPI.Application.Mappers
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressModel, AddressResponse>();
            CreateMap<CreateAddressRequest, AddressModel>();
        }
    }
}