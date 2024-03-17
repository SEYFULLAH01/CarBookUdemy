using CarBookUdemy.Application.Features.CQRS.Queries.BannerQueries;
using CarBookUdemy.Application.Features.CQRS.Queries.BrandQueries;
using CarBookUdemy.Application.Features.CQRS.Results.BannerResult;
using CarBookUdemy.Application.Features.CQRS.Results.BrandResult;
using CarBookUdemy.Application.Interfaces;
using CarBookUdemy.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var values = await _repository.GeByIdAsync(query.Id);
            return new GetBrandByIdQueryResult
            {
                BrandId = values.BrandId,
                Name = values.Name,
            };
        }
    }
}
