using MediatR;
using WebAPI.Application.DTO.Requests.Register;
using WebAPI.Application.DTO.Responses.Register;

namespace WebAPI.Application.Tasks.Commands.Register
{
    public class CreateLegalPersonCommand : IRequest<ResultTask<LegalPersonResponse>>
    {
        public CreateLegalPersonRequest Request { get; set; }
        public CreateLegalPersonCommand(CreateLegalPersonRequest request)
        {
            Request = request;
        }
    }
}