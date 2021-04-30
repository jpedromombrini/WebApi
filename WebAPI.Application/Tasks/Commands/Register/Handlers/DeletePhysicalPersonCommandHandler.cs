using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using WebAPI.Domain.Core.Interfaces.Services.Register;

namespace WebAPI.Application.Tasks.Commands.Register.Handlers
{
    public class DeletePhysicalPersonCommandHandler : IRequestHandler<DeletePhysicalPersonCommand, ResultTask>
    {
        private readonly IPhysicalPersonService _physicalPersonService;        
        public DeletePhysicalPersonCommandHandler(IPhysicalPersonService physicalPersonService)
        {
            _physicalPersonService = physicalPersonService;

        }
        public async Task<ResultTask> Handle(DeletePhysicalPersonCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = new ResultTask();
                var entity = await _physicalPersonService.GetByIdAsync(request.EntityId);

                if(entity != null)
                {
                    await _physicalPersonService.RemoveAsync(entity);
                    result.ValidOperation = true;
                }                    
                else
                {
                    result.ValidOperation = false;
                    result.Message = "Legal Person not exists";
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