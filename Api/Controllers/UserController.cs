using Application.Functions.Users.Queries.GetUserInfo;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetUserInfo")]
        public async Task<ActionResult<BaseResponse<UserInfoViewModel>>> GetUserInfo(int id)
        {
            return Ok(await _mediator.Send(new GetUserInfoQuery() { Id = id }));
        }
    }
}
