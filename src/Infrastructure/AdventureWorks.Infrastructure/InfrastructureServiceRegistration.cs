using AdventureWorks.Application.Contracts.Persistence;
using AdventureWorks.Infrastructure.Persistence;
using AdventureWorks.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<AdventureWorks2019Context>(options =>
                options.UseSqlServer(configuration.GetConnectionString("AdventureDbConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IShiftRepository, ShiftRepository>();
            return services;
        }
    }
}
