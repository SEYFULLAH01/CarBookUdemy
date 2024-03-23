using CarBookUdemy.Application.Features.Mediator.Commands.SeriveCommands;
using CarBookUdemy.Application.Features.Mediator.Commands.SocialMediaCommands;
using CarBookUdemy.Application.Features.Mediator.Queries.SocialMediaQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookUdemy.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SocialMediasController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> SocialMediaList()
        {
            var values = await _mediator.Send(new GetSocialMediaQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hizmet Başarıyla Eklendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocialMedia(int id)
        {
            var values = await _mediator.Send(new GetSocialMediaByIdQuery(id));
            return Ok(values);
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveSocialMedia(int id)
        {
            await _mediator.Send(new RemoveSocialMediaCommand(id));
            return Ok("Hizmet Başarıyla Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFotterAddress(UpdateSocialMediaCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hizmet Başarıyla güncellendi");
        }
    }
}
