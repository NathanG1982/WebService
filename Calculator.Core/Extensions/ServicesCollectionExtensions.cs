using Calculator.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.Core.Extensions
{
    public static class ServicesCollectionExtensions
    {
        /// <summary>
        /// Add Calculators services to service collection in order to use in DI
        /// </summary>
        /// <param name="services">The services</param>
        /// <returns>Collection of services</returns>
        public static IServiceCollection AddCalculator(this IServiceCollection services)
        {
            services.AddScoped<ICalculator, SimpleCalculator>();
            services.AddScoped<IProgrammerCalculator, ProgrammerCalculator>();
            return services;
        }
    }
}
