using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class RemoveSocialMediaCommand : IRequest
    {
        public RemoveSocialMediaCommand(int id) 
        {
            this.Id = id;
   
        }
                public int Id { get; set; }
    }
}