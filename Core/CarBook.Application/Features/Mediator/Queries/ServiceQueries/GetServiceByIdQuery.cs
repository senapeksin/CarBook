using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Results.ServiceResult;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery :IRequest<GetServiceByIdQueryResult>
    {
        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}