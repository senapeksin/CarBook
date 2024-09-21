using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FeautureHandlers
{
 public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;
        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }
     
 

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FooterID);
            values.Description = request.Description;
            values.Address = request.Address;
            values.Email = request.Email;
            values.Phone = request.Phone;
            await _repository.UpdateAsync(values);          
        }
    }
}
