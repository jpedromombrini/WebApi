using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using WebAPI.Application.DTO.Responses.Register;
using WebAPI.Domain.Core.Interfaces.Services.Register;
using WebAPI.Domain.Enums;
using WebAPI.Domain.Models;

namespace WebAPI.Application.Tasks.Commands.Register.Handlers
{
    public class UpdatePhysicalPersonCommandHandler : IRequestHandler<UpdatePhysicalPersonCommand, ResultTask<PhysicalPersonResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IPhysicalPersonService _physicalPersonService;
        private readonly IAddressService _addressService;
        public UpdatePhysicalPersonCommandHandler(IMapper mapper, IPhysicalPersonService physicalPersonService, IAddressService addressService)
        {
            _mapper = mapper;
            _physicalPersonService = physicalPersonService;
            _addressService = addressService;
        }

        public async Task<ResultTask<PhysicalPersonResponse>> Handle(UpdatePhysicalPersonCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var result = new ResultTask<PhysicalPersonResponse>();
                var entity = await _physicalPersonService.GetByIdAsync(command.Request.Id);
                if (entity == null)
                {
                    result.ValidOperation = false;
                    result.Message = "Legal Person not exists";
                    result.Value = null;
                }
                else
                {
                    var address = await _addressService.GetByPersonId(entity.Id);

                    entity.Cpf = command.Request.Cpf;
                    entity.Email = command.Request.Email;
                    entity.Observation = command.Request.Observation;
                    entity.Name = command.Request.Name;
                    entity.Phone = command.Request.Phone;
                    entity.PersonType = (PersonTypeEnum)command.Request.PersonType;
                    address.PublicPlace = command.Request.Address.PublicPlace;
                    address.Neighborhood = command.Request.Address.Neighborhood;
                    address.City = command.Request.Address.City;
                    address.ZipCode = command.Request.Address.ZipCode;
                    address.State = command.Request.Address.State;

                    entity.Address = address;                    
                    await _physicalPersonService.UpdateAsync(entity);
                    
                    result.Value = _mapper.Map<PhysicalPersonResponse>(entity);
                    result.ValidOperation = true;
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