using CarBookUdemy.Application.Features.CQRS.Commands.BannerCommands;
using CarBookUdemy.Application.Features.CQRS.Commands.BrandCommands;
using CarBookUdemy.Application.Interfaces;
using CarBookUdemy.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public UpdateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBrandCommand command)
        {
            var values = await _repository.GeByIdAsync(command.BrandId);
            values.Name=command.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
