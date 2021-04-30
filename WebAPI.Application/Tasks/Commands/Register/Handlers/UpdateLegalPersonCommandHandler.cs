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
    public class UpdateLegalPersonCommandHandler : IRequestHandler<UpdateLegalPersonCommand, ResultTask<LegalPersonResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ILegalPersonService _legalPersonService;
        public UpdateLegalPersonCommandHandler(IMapper mapper, ILegalPersonService legalPersonService)
        {
            _mapper = mapper;
            _legalPersonService = legalPersonService;
        }
        public async Task<ResultTask<LegalPersonResponse>> Handle(UpdateLegalPersonCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var result = new ResultTask<LegalPersonResponse>();
                var entity = _mapper.Map<LegalPersonModel>(command.Request);

                var exists = await _legalPersonService.GetByCnpjAsync(entity.Cnpj);
                if(exists == null)
                {
                    result.ValidOperation = false;
                    result.Message = "Legal Person not exists";
                    result.Value = null;
                }
                else
                {
                    await _legalPersonService.UpdateAsync(entity);
                    result.Value = _mapper.Map<LegalPersonResponse>(entity);
                    result.ValidOperation = true;
                }

                return result;

            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}