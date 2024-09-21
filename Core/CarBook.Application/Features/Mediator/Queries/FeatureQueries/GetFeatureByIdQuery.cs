using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Results.FeatureResult;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery : IRequest<GetFeautreByIdQueryResult>
    {
        public GetFeatureByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}