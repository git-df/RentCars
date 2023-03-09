using Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Data;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class PersistenceInstalation
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RentCarsDbContext>(options =>
                options.UseSqlServer(configuration.
                GetConnectionString("RentCarsConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IPersonalDataRepository, PersonalDataRepository>();
            services.AddScoped<IRentRepository, RentRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IOfferRepository, OfferRepository>();
            services.AddScoped<IBranchRepository, BranchRepository>();
            services.AddScoped<IBranchEmployeeRepository, BranchEmployeeRepository>();
            services.AddScoped<IModelOfCarsRepository, ModelOfCarsRepository>();
            services.AddScoped<ICarAttributeRepository, CarAttributeRepository>();

            return services;
        }
    }
}
