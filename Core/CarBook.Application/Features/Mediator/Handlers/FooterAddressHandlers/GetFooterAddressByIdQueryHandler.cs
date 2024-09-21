using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Queries.FeatureAddressQueries;
using CarBook.Application.Features.Mediator.Results.FeatureResult;
using CarBook.Application.Features.Mediator.Results.FooterAddressResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

using MediatR;

namespace CarBook.Application.FooterAddresss.Mediator.Handlers.FeautureHandlers
{
    public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
    {
        private readonly IRepository<FooterAddress> _repository;
        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

     public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
             var values = await _repository.GetByIdAsync(request.Id);
                return  new GetFooterAddressByIdQueryResult {
                FooterAddressID = values.FooterAddressID,
                Email = values.Email,
                Phone = values.Phone,
                Description = values.Description  
            };    
        }
    }
}