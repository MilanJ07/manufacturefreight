using Microsoft.Extensions.DependencyInjection;

namespace ManufactureFreight.Models.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddModelValidators(this IServiceCollection services)
        {
            //services.AddScoped<Validators>();

            return services;
        }
    }
}
