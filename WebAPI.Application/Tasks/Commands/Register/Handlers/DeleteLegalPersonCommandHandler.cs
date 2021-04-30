using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using WebAPI.Domain.Core.Interfaces.Services.Register;

namespace WebAPI.Application.Tasks.Commands.Register.Handlers
{
    public class DeleteLegalPersonCommandHandler : IRequestHandler<DeleteLegalPersonCommand, ResultTask>
    {
        private readonly ILegalPersonService _legalPersonService;
        public DeleteLegalPersonCommandHandler(ILegalPersonService legalPersonService)
        {
            _legalPersonService = legalPersonService;
            
        }
        public async Task<ResultTask> Handle(DeleteLegalPersonCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = new ResultTask();
                var entity = await _legalPersonService.GetByIdAsync(request.EntityId);

                if(entity != null)
                {
                    await _legalPersonService.RemoveAsync(entity);
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