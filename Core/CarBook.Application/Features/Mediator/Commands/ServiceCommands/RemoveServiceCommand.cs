using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ServiceCommands
{
    public class RemoveServiceCommand :IRequest
    {
        public RemoveServiceCommand(int id) 
        {
            this.Id = id;
   
        }
              public int Id { get; set; }  
    }
}