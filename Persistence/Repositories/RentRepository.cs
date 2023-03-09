using Application.Contracts.Persistence;
using Domain.Entities;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RentRepository : AsyncRepository<Rent>, IRentRepository
    {
        public RentRepository(RentCarsDbContext rentCarsDbContext) : base(rentCarsDbContext)
        {
        }
    }
}
