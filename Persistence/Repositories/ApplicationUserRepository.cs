using Application.Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ApplicationUserRepository : AsyncRepository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(RentCarsDbContext rentCarsDbContext) : base(rentCarsDbContext)
        {
        }

        public async Task<ApplicationUser?> GetByEmail(string email)
        {
            return await _context.ApplicationUsers.Include(a => a.PersonalData).Include(a => a.Employee).AsNoTracking().FirstOrDefaultAsync(a => a.Email == email);
        }

        public async Task<ApplicationUser?> GetById(int id)
        {
            return await _context.ApplicationUsers.Include(a => a.PersonalData).Include(a => a.Employee).AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
