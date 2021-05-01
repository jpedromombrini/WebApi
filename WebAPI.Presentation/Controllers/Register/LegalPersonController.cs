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
    public class LegalPersonController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LegalPersonController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] CreateLegalPersonRequest request)
        {
            var result = await _mediator.Send(new CreateLegalPersonCommand(request));
            return Ok(result);
        }
        [HttpDelete]
        [Route("{entityId}")]
        public async Task<IActionResult> DeleteAsync(Guid entityId)
        {
            var result = await _mediator.Send(new DeleteLegalPersonCommand(entityId));
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody]UpdateLegalPersonRequest request)
        {
            var result = await _mediator.Send(new UpdateLegalPersonCommand(request));
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetByParamsasync([FromQuery] GetLegalPersonsByParamsFilter filter)
        {
            var result = await _mediator.Send(new GetLegalPersonsByParamsQuery(filter));
            return Ok(result);
        }
    }
}