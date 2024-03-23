using CarBookUdemy.Application.Features.Mediator.Queries.FooterAddressQueries;
using CarBookUdemy.Application.Features.Mediator.Results.FeatureResults;
using CarBookUdemy.Application.Features.Mediator.Results.FooterAddressResults;
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
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult
            {
               Address = x.Address,
               Phone = x.Phone,
               FooterAddressId = x.FooterAddressId,
               Description = x.Description,
               Email = x.Email
            }).ToList();
        }
    }
}
