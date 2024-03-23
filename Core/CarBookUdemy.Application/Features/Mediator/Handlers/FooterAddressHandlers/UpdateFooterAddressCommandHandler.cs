using CarBookUdemy.Application.Features.Mediator.Commands.FeatureCommands;
using CarBookUdemy.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBookUdemy.Application.Interfaces;
using CarBookUdemy.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;
        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FooterAddressId);
            values.Phone = request.Phone;
            values.Email = request.Email;
            values.Address = request.Address;
            values.FooterAddressId = request.FooterAddressId;
            await _repository.UpdateAsync(values);
        }
    }
}
