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
    public class UpdatePhysicalPersonCommandHandler : IRequestHandler<UpdatePhysicalPersonCommand, ResultTask<PhysicalPersonResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IPhysicalPersonService _physicalPersonService;
        public UpdatePhysicalPersonCommandHandler(IMapper mapper, IPhysicalPersonService physicalPersonService)
        {
            _mapper = mapper;
            _physicalPersonService = physicalPersonService;
        }
        
        public async Task<ResultTask<PhysicalPersonResponse>> Handle(UpdatePhysicalPersonCommand command, CancellationToken cancellationToken)
        {
            try
            {
                 var result = new ResultTask<PhysicalPersonResponse>();
                var entity = _mapper.Map<PhysicalPersonModel>(command.Request);

                var exists = await _physicalPersonService.GetByCpfAsync(entity.Cpf);
                if(exists == null)
                {
                    result.ValidOperation = false;
                    result.Message = "Legal Person not exists";
                    result.Value = null;
                }
                else
                {
                    await _physicalPersonService.UpdateAsync(entity);
                    result.Value = _mapper.Map<PhysicalPersonResponse>(entity);
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