using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Results.FooterAddressResult;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.FooterAddressQueries
{ 
    public class GetFooterAddressQuery: IRequest<List<GetFooterAddresQueryResult>>
    {
        
    }
}