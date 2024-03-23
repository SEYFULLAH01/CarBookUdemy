using CarBookUdemy.Application.Features.CQRS.Queries.AboutQueries;
using CarBookUdemy.Application.Features.CQRS.Results.AboutResult;
using CarBookUdemy.Application.Features.CQRS.Results.BrandResult;
using CarBookUdemy.Application.Features.Mediator.Queries.FeatureQueries;
using CarBookUdemy.Application.Features.Mediator.Results.FeatureResults;
using CarBookUdemy.Application.Interfaces;
using CarBookUdemy.Domain.Entites;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler : 
        IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetFeatureByIdQueryResult
            {
                FeatureId = values.FeatureId,
                Name = values.Name
            };
        }
    }
}
