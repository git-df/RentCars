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
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<PersonalData> PersonalDatas { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarAttribute> CarAttributes { get; set; }
        public DbSet<ModelOfCars> ModelsOfCars { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<BranchEmployee> BranchEmployees { get; set; }

        public RentCarsDbContext(DbContextOptions<RentCarsDbContext> options) : base(options)
        {
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User
            modelBuilder.Entity<ApplicationUser>(e =>
            {
                e.HasOne(a => a.PersonalData)
                    .WithOne(a => a.ApplicationUser)
                    .HasForeignKey<ApplicationUser>(a => a.PersonalDataId);

                e.HasOne(a => a.Employee)
                    .WithOne(e => e.ApplicationUser)
                    .HasForeignKey<ApplicationUser>(a => a.EmployeeId);

                e.HasMany(a => a.Rents)
                    .WithOne(r => r.ApplicationUser)
                    .HasForeignKey(r => r.ApplicationUserId);
            });

            //Employee
            modelBuilder.Entity<Employee>(e =>
            {
                e.HasOne(e => e.ApplicationUser)
                    .WithOne(a => a.Employee)
                    .HasForeignKey<ApplicationUser>(a => a.EmployeeId);

                e.HasMany(e => e.BranchEmployees)
                    .WithOne(be => be.Employee)
                    .HasForeignKey(be => be.EmployeeId);
            });

            //PersonalData
            modelBuilder.Entity<PersonalData>(e => 
            {
                e.HasOne(p => p.ApplicationUser)
                    .WithOne(a => a.PersonalData)
                    .HasForeignKey<ApplicationUser>(a => a.PersonalDataId);
            });

            //Branch
            modelBuilder.Entity<Branch>(e =>
            {
                e.HasMany(b => b.BranchEmployees)
                    .WithOne(be => be.Branch)
                    .HasForeignKey(be => be.BranchId);

                e.HasMany(b => b.Offers)
                    .WithOne(o => o.Branch)
                    .HasForeignKey(o => o.BranchId);
            });

            //Branch - Employe (meny - meny)
            modelBuilder.Entity<BranchEmployee>(e =>
            {
                e.HasOne(be => be.Employee)
                    .WithMany(e => e.BranchEmployees)
                    .HasForeignKey(be => be.EmployeeId);

                e.HasOne(be => be.Branch)
                    .WithMany(b => b.BranchEmployees)
                    .HasForeignKey(be => be.BranchId);
            });

            //Ofer
            modelBuilder.Entity<Offer>(e =>
            {
                e.HasOne(o => o.Branch)
                    .WithMany(b => b.Offers)
                    .HasForeignKey(o => o.BranchId);

                e.HasOne(o => o.Car)
                    .WithMany(c => c.Offers)
                    .HasForeignKey(o => o.CarId);
            });

            //Car
            modelBuilder.Entity<Car>(e =>
            {
                e.HasMany(c => c.Offers)
                    .WithOne(o => o.Car)
                    .HasForeignKey(o => o.CarId);

                e.HasMany(c => c.carAttributes)
                    .WithOne(ca => ca.Car)
                    .HasForeignKey(ca => ca.CarId);

                e.HasOne(c => c.ModelOfCars)
                    .WithMany(m => m.Cars)
                    .HasForeignKey(c => c.ModelOfCarsId);

                e.HasMany(c => c.Rents)
                    .WithOne(r => r.Car)
                    .HasForeignKey(r => r.CarId);
            });

            //CarAttribute
            modelBuilder.Entity<CarAttribute>(e =>
            {
                e.HasOne(ca => ca.Car)
                    .WithMany(c => c.carAttributes)
                    .HasForeignKey(ca => ca.CarId);
            });

            //ModelOfCar
            modelBuilder.Entity<ModelOfCars>(e =>
            {
                e.HasMany(m => m.Cars)
                    .WithOne(c => c.ModelOfCars)
                    .HasForeignKey(c => c.ModelOfCarsId);
            });

            //Rent
            modelBuilder.Entity<Rent>(e =>
            {
                e.HasOne(r => r.Car)
                    .WithMany(c => c.Rents)
                    .HasForeignKey(r => r.CarId);
                
                e.HasOne(r => r.Payment)
                    .WithOne(p => p.Rent)
                    .HasForeignKey<Rent>(r => r.CarId);


                e.HasOne(r => r.ApplicationUser)
                    .WithMany(a => a.Rents)
                    .HasForeignKey(r => r.ApplicationUserId);
            });

            //Payment
            modelBuilder.Entity<Payment>(e =>
            {
                e.HasOne(p => p.Rent)
                    .WithOne(r => r.Payment)
                    .HasForeignKey<Payment>(p => p.RentId);
            });
        }
    }
}
