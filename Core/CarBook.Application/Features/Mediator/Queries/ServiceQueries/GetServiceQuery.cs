using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using CarBook.Application.Features.Mediator.Results.ServiceResult;

namespace CarBook.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery:IRequest<List<GetServiceQueryResult>>
    {
         public int ServiceID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}