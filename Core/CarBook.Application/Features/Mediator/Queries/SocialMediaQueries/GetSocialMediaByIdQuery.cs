using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Results.SocialMediaResult;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery :IRequest<GetSocialMediaByIdQueryResult>
    {
        public GetSocialMediaByIdQuery(int id) 
        {
            this.Id = id;
   
        }
                public int Id { get; set; }
    }
}