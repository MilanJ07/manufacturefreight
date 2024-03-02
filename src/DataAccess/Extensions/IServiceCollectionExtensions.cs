using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ManufactureFreight.BusinessLogic.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessLogicDependencies(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            //services.Configure<ConnectionString>(configuration.GetSection("ConnectionString"));
            services.AddScoped<IPlantRepository, PlantRepository>();

            return services;
        }
    }
}
