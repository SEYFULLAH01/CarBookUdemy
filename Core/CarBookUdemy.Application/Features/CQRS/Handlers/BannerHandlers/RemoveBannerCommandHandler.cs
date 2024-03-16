using CarBookUdemy.Application.Features.CQRS.Commands.AboutCommands;
using CarBookUdemy.Application.Features.CQRS.Commands.BannerCommands;
using CarBookUdemy.Application.Interfaces;
using CarBookUdemy.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class RemoveBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public RemoveBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveBannerCommand command)
        {
            var value = await _repository.GeByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
