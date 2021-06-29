using AutoMapper;
using WebAPI.Application.DTO.Requests.Security;
using WebAPI.Application.DTO.Responses.Security;
using WebAPI.Domain.Models.Security;

namespace WebAPI.Application.Mappers.Security
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel, UserResponse>();
            CreateMap<CreateUserRequest, UserModel>();            
        }
    }
}