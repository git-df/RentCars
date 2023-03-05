using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data
{
    public class RentCarsDbContext : DbContext
    {
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<PersonalData> PersonalDatas { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Branch> Branches { get; set; }

        public RentCarsDbContext(DbContextOptions<RentCarsDbContext> options) : base(options)
        {  
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
