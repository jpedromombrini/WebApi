using MediatR;
using WebAPI.Application.DTO.Requests;
using WebAPI.Application.DTO.Responses;

namespace WebAPI.Application.Tasks.Commands
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