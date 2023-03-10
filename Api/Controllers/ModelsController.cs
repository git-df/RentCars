using Application.Functions.ModelOfCars.Queries.GetBrandsAndModels;
using Application.Functions.Users.Queries.GetUserInfo;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ModelsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> GetDistinctModels()
        {
            return Ok(await _mediator.Send(new GetDistinctModelsQuery()));
        }
    }
}
