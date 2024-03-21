using CarBookUdemy.Application.Features.CQRS.Commands.BannerCommands;
using CarBookUdemy.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBookUdemy.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBookUdemy.Application.Features.CQRS.Queries.AboutQueries;
using CarBookUdemy.Application.Features.CQRS.Queries.BannerQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookUdemy.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly CreateBannerCommandHandler _creatBannerCommandHandler;
        private readonly GetBannerByIdQueryHandler _getBannerByIdQueryHandler;
        private readonly GetBannerQueryHandler _getBannerQueryHandler;
        private readonly UpdateBannerCommandHandler _updateBannerCommandHandler;
        private readonly RemoveBannerCommandHandler _removeBannerCommandHandler;

        public BannersController(CreateBannerCommandHandler creatBannerCommandHandler,
            GetBannerByIdQueryHandler getBannerByIdQueryHandler, 
            GetBannerQueryHandler getBannerQueryHandler, 
            UpdateBannerCommandHandler updateBannerCommandHandler,
            RemoveBannerCommandHandler removeBannerCommandHandler)
        {
            _creatBannerCommandHandler = creatBannerCommandHandler;
            _getBannerByIdQueryHandler = getBannerByIdQueryHandler;
            _getBannerQueryHandler = getBannerQueryHandler;
            _updateBannerCommandHandler = updateBannerCommandHandler;
            _removeBannerCommandHandler = removeBannerCommandHandler;
        }
        [HttpGet]
        public IActionResult BannerList()
        {
            var values = _getBannerQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBanner(int id)
        {
            var value = await _getBannerByIdQueryHandler.Handle(new GetBannerByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommand command)
        {
            await _creatBannerCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveBanner(int id)
        {
            await _removeBannerCommandHandler.Handle(new RemoveBannerCommand(id));
            return Ok("Bilgi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerCommand command)
        {
            await _updateBannerCommandHandler.Handle(command);
            return Ok("Bilgi Güncellendi");
        }
    }
}
