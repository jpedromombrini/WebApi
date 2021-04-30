using MediatR;
using WebAPI.Application.DTO.Requests.Register;
using WebAPI.Application.DTO.Responses.Register;

namespace WebAPI.Application.Tasks.Commands.Register
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