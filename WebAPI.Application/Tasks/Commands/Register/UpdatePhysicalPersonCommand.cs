using MediatR;
using WebAPI.Application.DTO.Requests.Register;
using WebAPI.Application.DTO.Responses.Register;

namespace WebAPI.Application.Tasks.Commands.Register
{
    public class UpdatePhysicalPersonCommand : IRequest<ResultTask<PhysicalPersonResponse>>
    {
        public UpdatePhysicalPersonRequest Request { get; set; }
        public UpdatePhysicalPersonCommand(UpdatePhysicalPersonRequest request)
        {
            Request = request;
        }
    }
}