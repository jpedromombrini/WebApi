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
    public class UpdateLegalPersonCommandHandler : IRequestHandler<UpdateLegalPersonCommand, ResultTask<LegalPersonResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ILegalPersonService _legalPersonService;
        private readonly IAddressService _addressService;
        public UpdateLegalPersonCommandHandler(IMapper mapper, ILegalPersonService legalPersonService, IAddressService addressService)
        {
            _mapper = mapper;
            _legalPersonService = legalPersonService;
            _addressService = addressService;
        }
        public async Task<ResultTask<LegalPersonResponse>> Handle(UpdateLegalPersonCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var result = new ResultTask<LegalPersonResponse>();
                var entity = await _legalPersonService.GetByIdAsync(command.Request.Id);
                
                if(entity == null)
                {
                    result.ValidOperation = false;
                    result.Message = "Legal Person not exists";
                    result.Value = null;
                }
                else
                {
                    var address = await _addressService.GetByPersonId(entity.Id);

                    entity.Cnpj = command.Request.Cnpj;
                    entity.CompanyName = command.Request.CompanyName;
                    entity.Subscription = command.Request.Subscription;
                    entity.Fantasy = command.Request.Fantasy;
                    entity.Observation = command.Request.Observation;
                    entity.PersonType = (PersonTypeEnum)command.Request.PersonType;
                    entity.Email = command.Request.Email;
                    entity.Phone = command.Request.Phone;
                    address.PublicPlace = command.Request.Address.PublicPlace;
                    address.Neighborhood = command.Request.Address.Neighborhood;
                    address.City = command.Request.Address.City;
                    address.ZipCode = command.Request.Address.ZipCode;
                    address.State = command.Request.Address.State;
                    
                    entity.Address = address;
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