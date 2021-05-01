using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.DTO.Filters.Register;
using WebAPI.Application.DTO.Requests.Register;
using WebAPI.Application.Tasks.Commands.Register;
using WebAPI.Application.Tasks.Queries.Register;

namespace WebAPI.Presentation.Controllers.Register
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhysicalPersonController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PhysicalPersonController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] CreatePhysicalPersonRequest request)
        {
            var result = await _mediator.Send(new CreatePhysicalPersonCommand(request));
            return Ok(result);
        }
        [HttpDelete]
        [Route("{entityId}")]
        public async Task<IActionResult> DeleteAsync(Guid entityId)
        {
            var result = await _mediator.Send(new DeletePhysicalPersonCommand(entityId));
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody]UpdatePhysicalPersonRequest request)
        {
            var result = await _mediator.Send(new UpdatePhysicalPersonCommand(request));
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetByParamsasync([FromQuery] GetPhysicalPersonsByParamsFilter filter)
        {
            var result = await _mediator.Send(new GetPhysicalPersonsByParamsQuery(filter));
            return Ok(result);
        }
    }
}