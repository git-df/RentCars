using Application.Functions.Auth.Command.SignIn;
using Application.Functions.Auth.Command.SignUp;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignIn([FromBody] SignInCommand request)
        {
            return Ok(await _mediator.Send(request));
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignUp([FromBody] SignUpCommand request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
