using DataAccess;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ManufactureFreight.DataAccess.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            //services.Configure<ConnectionString>(configuration.GetSection("ConnectionString"));
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseOracle(configuration.GetConnectionString("Oracle")));
            services.AddScoped<IPlantRepository, PlantRepository>();

            return services;
        }
    }
}
