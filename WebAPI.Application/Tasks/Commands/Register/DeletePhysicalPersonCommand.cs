using System;
using MediatR;

namespace WebAPI.Application.Tasks.Commands.Register
{
    public class DeletePhysicalPersonCommand : IRequest<ResultTask>
    {
        public Guid EntityId { get; set; }
        public DeletePhysicalPersonCommand(Guid entityId)
        {
            EntityId = entityId;
        }
    }
}