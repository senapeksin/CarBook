using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class UpdateFooterAddressCommand : IRequest
    {
        public int FooterID { get; set; }
       public string Description { get; set; } 
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}