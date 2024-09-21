using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using CarBook.Application.Features.Mediator.Queries.LocationQueries;
using CarBook.Application.Features.Mediator.Results.LocationResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

using MediatR;

namespace CarBook.Application.Locations.Mediator.Handlers.LocationHandlers
{
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly IRepository<Location> _repository;
        public GetLocationByIdQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

     public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
             var values = await _repository.GetByIdAsync(request.Id);
                return  new GetLocationByIdQueryResult {
                LocationID = values.LocationID,
                Name = values.Name  
            };    
        }
    }
}