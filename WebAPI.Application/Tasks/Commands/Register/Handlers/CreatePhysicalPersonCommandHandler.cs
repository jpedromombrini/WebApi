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
    public class CreatePhysicalPersonCommandHandler : IRequestHandler<CreatePhysicalPersonCommand, ResultTask<PhysicalPersonResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IPhysicalPersonService _physicalPersonService;

        public CreatePhysicalPersonCommandHandler(IMapper mapper, IPhysicalPersonService physicalPersonService)
        {
            _mapper = mapper;
            _physicalPersonService = physicalPersonService;
        }
        public async Task<ResultTask<PhysicalPersonResponse>> Handle(CreatePhysicalPersonCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var result = new ResultTask<PhysicalPersonResponse>();
                var entity = _mapper.Map<PhysicalPersonModel>(command.Request);
                var exists = await _physicalPersonService.GetByCpfAsync(entity.Cpf);
                if (exists == null)
                {
                    await _physicalPersonService.AddAsync(entity);
                    result.Value = _mapper.Map<PhysicalPersonResponse>(entity);
                    result.ValidOperation = true;
                }
                else
                {
                    result.ValidOperation = false;
                    result.Message = "Physical Person exist";
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