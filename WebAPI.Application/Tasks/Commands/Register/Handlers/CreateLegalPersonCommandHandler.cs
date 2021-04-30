using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using WebAPI.Application.DTO.Responses.Register;
using WebAPI.Domain.Core.Interfaces.Services.Register;
using WebAPI.Domain.Models;

namespace WebAPI.Application.Tasks.Commands.Register.Handlers
{
    public class CreateLegalPersonCommandHandler : IRequestHandler<CreateLegalPersonCommand, ResultTask<LegalPersonResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ILegalPersonService _legalPersonService;
        public CreateLegalPersonCommandHandler(IMapper mapper, ILegalPersonService legalPersonService)
        {
            _mapper = mapper;
            _legalPersonService = legalPersonService;
        }
        public async Task<ResultTask<LegalPersonResponse>> Handle(CreateLegalPersonCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var result = new ResultTask<LegalPersonResponse>();
                var entity = _mapper.Map<LegalPersonModel>(command.Request);
                var exists = await _legalPersonService.GetByCnpjAsync(entity.Cnpj);
                if (exists == null)
                {
                    await _legalPersonService.AddAsync(entity);
                    result.Value = _mapper.Map<LegalPersonResponse>(entity);
                    result.ValidOperation = true;
                }
                else
                {
                    result.ValidOperation = false;
                    result.Message = "Legal Persons exists";
                    result.Value = null;
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}