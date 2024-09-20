using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<GetCarWithBrandQueryResult>>  Handle(){
            var values = await _repository.GetCarsListWithBrands();
             return values.Select(x=> new GetCarWithBrandQueryResult {
                    CarID = x.CarID,
                    BrandID = x.BrandID,
                    BrandName = x.Brand.Name,
                    Model = x.Model,
                    CoverImageUrl = x.CoverImageUrl,
                    Km =    x.Km,
                    Transmission = x.Transmission,
                    Seat = x.Seat,
                    Luggage = x.Luggage,
                    Fuel = x.Fuel,
                    BigImageUrl = x.BigImageUrl

             }).ToList();
        }
    }
}