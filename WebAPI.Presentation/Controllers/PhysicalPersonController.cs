using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.DTO.Requests;
using WebAPI.Application.Tasks.Commands;

namespace WebAPI.Presentation.Controllers
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
    }
}