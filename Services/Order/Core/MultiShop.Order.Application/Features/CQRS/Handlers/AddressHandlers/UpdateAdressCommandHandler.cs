using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAdressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public UpdateAdressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddressCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AddressId);
            values.Detail1 = command.Detail;
            values.Disctrict = command.Disctrict;
            values.City = command.City;
            values.UserId = command.UserId;
            await _repository.UpdateAsync(values);
        }
    }
}
