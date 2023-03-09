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
    public class PersonalDataRepository : AsyncRepository<PersonalData>, IPersonalDataRepository
    {
        public PersonalDataRepository(RentCarsDbContext rentCarsDbContext) : base(rentCarsDbContext)
        {
        }
    }
}
