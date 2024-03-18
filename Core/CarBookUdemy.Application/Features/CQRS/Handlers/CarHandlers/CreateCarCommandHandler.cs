using CarBookUdemy.Application.Features.CQRS.Commands.CarCommands;
using CarBookUdemy.Application.Interfaces;
using CarBookUdemy.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = command.BigImageUrl,
                Luggage = command.Luggage,
                Km= command.Km,
                Model = command.Model,
                Seat = command.Seat,
                Transmission = command.Transmission,
                Fuel = command.Fuel,
                BrandId = command.BrandId,
            });
        }
    }
}
