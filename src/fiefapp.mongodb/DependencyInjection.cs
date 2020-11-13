using fiefapp.mongodb.Repositories.BuildingAlternative;
using Microsoft.Extensions.DependencyInjection;

namespace fiefapp.mongodb
{
    public static class DependencyInjection
    {
        public static IServiceCollection DI_MongoDB(this IServiceCollection services)
        {
            //services.AddSingleton<IDatabaseSettings, DatabaseSettings>();

            services.AddTransient<IBuildingAlternativeRepository, BuildingAlternativeRepository>();

            return services;
        }
    }
}
