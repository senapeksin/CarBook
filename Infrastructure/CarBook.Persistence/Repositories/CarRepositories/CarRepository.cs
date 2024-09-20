using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
    public class CarRepository  : ICarRepository 
{
    private readonly CarBookContext _context;

        public async Task<List<Car>> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }
    }

}