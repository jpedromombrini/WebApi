using System;
using MediatR;

namespace WebAPI.Application.Tasks.Commands.Register
{
    public class DeleteLegalPersonCommand : IRequest<ResultTask>
    {
        public Guid EntityId { get; set; }
        public DeleteLegalPersonCommand(Guid entityId)
        {
            EntityId = entityId;
        }
    }
}