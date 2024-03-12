using BusinessLogic.Interfaces.Masters;
using BusinessLogic.Mappings.Masters;
using BusinessLogic.Services.Masters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ManufactureFreight.BusinessLogic.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessLogicDependencies(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            services.AddScoped<IPlantService, PlantService>();
            services.AddAutoMapper(typeof(PlantMappingProfile).Assembly);

            return services;
        }
    }
}
