using CarBookUdemy.Application.Features.CQRS.Queries.AboutQueries;
using CarBookUdemy.Application.Features.CQRS.Queries.BannerQueries;
using CarBookUdemy.Application.Features.CQRS.Results.AboutResult;
using CarBookUdemy.Application.Features.CQRS.Results.BannerResult;
using CarBookUdemy.Application.Interfaces;
using CarBookUdemy.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values = await _repository.GeByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
                BannerId = values.BannerId,
                Description = values.Description,
                Title = values.Title,
                VideoDescription = values.VideoDescription,
                VideoUrl = values.VideoUrl,
            };
        }
    }
}
