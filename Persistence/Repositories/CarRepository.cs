using Application.Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class CarRepository : AsyncRepository<Car>, ICarRepository
    {
        public CarRepository(RentCarsDbContext rentCarsDbContext) : base(rentCarsDbContext)
        {
        }

        public async Task<List<Car>> GetByModel(string? brandName = null, string? modelName = null)
        {
            if(!brandName.IsNullOrEmpty() && !modelName.IsNullOrEmpty())
                return await _context.Cars.Where(c => c.ModelOfCars.BrandName == brandName && c.ModelOfCars.ModelName == modelName).Include(c => c.ModelOfCars).AsNoTracking().ToListAsync();

            return await _context.Cars.Include(c => c.ModelOfCars).AsNoTracking().ToListAsync();
        }
    }
}
