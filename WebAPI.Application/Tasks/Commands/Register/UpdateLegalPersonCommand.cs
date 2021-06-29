using MediatR;
using WebAPI.Application.DTO.Requests.Register;
using WebAPI.Application.DTO.Responses.Register;

namespace WebAPI.Application.Tasks.Commands.Register
{
    public class UpdateLegalPersonCommand : IRequest<ResultTask<LegalPersonResponse>>
    {
        public UpdateLegalPersonRequest Request { get; set; }
        public UpdateLegalPersonCommand(UpdateLegalPersonRequest request)
        {
            Request = request;
        }
        
    }
}