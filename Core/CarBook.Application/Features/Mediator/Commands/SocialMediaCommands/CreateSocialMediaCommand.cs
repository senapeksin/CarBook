using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class CreateSocialMediaCommand :IRequest
    {
         public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}