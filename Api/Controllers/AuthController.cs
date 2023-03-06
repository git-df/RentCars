using Application.Functions.Auth.Command.SignIn;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ActionResult<BaseResponse<string>>> SignIn([FromBody] string email, [FromBody] string password)
        {
            return Ok(await _mediator.Send(new SignInCommand() { Email = email, Password = password }));
        }
    }
}
