using CarBookUdemy.Application.Features.Mediator.Queries.SocialMediaQueries;
using CarBookUdemy.Application.Features.Mediator.Results.SocialMediaResults;
using CarBookUdemy.Application.Interfaces;
using CarBookUdemy.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Features.Mediator.Handlers.SocaialMediaHandlers
{
    public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        private readonly IRepository<SocialMedia> _repository;

        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResult
            {
                Url = x.Url,
                SocialMediaId = x.SocialMediaId,
                Icon = x.Icon,
                Name = x.Name
            }).ToList();
        }
    }
}
