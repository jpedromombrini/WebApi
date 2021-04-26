using MediatR;
using WebAPI.Application.DTO.Requests;
using WebAPI.Application.DTO.Responses;

namespace WebAPI.Application.Tasks.Commands
{
    public class CreatePhysicalPersonCommand : IRequest<ResultTask<PhysicalPersonResponse>>
    {
        public CreatePhysicalPersonRequest Request { get; set; }
        public CreatePhysicalPersonCommand(CreatePhysicalPersonRequest request)
        {
            Request = request;
        }
    }
}