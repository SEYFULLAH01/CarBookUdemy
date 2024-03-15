using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Features.CQRS.Results.AboutResult
{
    public class GetAboutByIdQueryResult
    {
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
