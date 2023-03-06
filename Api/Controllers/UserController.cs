using Application.Functions.Users.Queries.GetUserInfo;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize]
        [HttpGet(Name = "GetUserInfo")]
        public async Task<ActionResult<BaseResponse<GetUserInfoQueryViewModel>>> GetUserInfo()
        {
            string? idClaimValue = (HttpContext.User.Identity as ClaimsIdentity)?.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            return idClaimValue != null 
                ? Ok(await _mediator.Send(new GetUserInfoQuery() { Id = Int32.Parse(idClaimValue) })) 
                : BadRequest(new BaseResponse<GetUserInfoQueryViewModel>("Nie jesteś zalogowany", false));
        }
    }
}
