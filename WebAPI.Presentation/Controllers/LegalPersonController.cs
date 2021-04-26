using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.DTO.Requests;
using WebAPI.Application.Tasks.Commands;

namespace WebAPI.Presentation.Controllers
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
    }
}