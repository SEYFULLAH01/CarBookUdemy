using CarBookUdemy.Application.Features.CQRS.Results.AboutResult;
using CarBookUdemy.Application.Interfaces;
using CarBookUdemy.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _repository;
        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAboutQueryResult>> Handle()
        {
            var values = _repository.GeAllAsync().Result;
            return values.Select(x => new GetAboutQueryResult
            {
                AboutId = x.AboutId,
                Description = x.Description,
                Title = x.Title,
                ImageUrl = x.ImageUrl,
            }).ToList();
        }
    }
}
