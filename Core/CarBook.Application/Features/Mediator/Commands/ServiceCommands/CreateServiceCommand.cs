using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ServiceCommands
{
    public class CreateServiceCommand : IRequest
    {
         public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}