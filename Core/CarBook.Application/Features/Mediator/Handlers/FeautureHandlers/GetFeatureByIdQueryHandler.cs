using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using CarBook.Application.Features.Mediator.Queries.FeatureQueries;
using CarBook.Application.Features.Mediator.Results.FeatureResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FeautureHandlers
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeautreByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;
        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

     public async Task<GetFeautreByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
             var values = await _repository.GetByIdAsync(request.Id);
                return  new GetFeautreByIdQueryResult {
                FeatureID = values.FeatureID,
                Name = values.Name  
            };    
        }
    }
}