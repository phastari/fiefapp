using fiefapp.mongodb.Repositories;
using fiefapp.services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace fiefapp.mongodb
{
    public static class DependencyInjection
    {
        public static IServiceCollection DI_MongoDB(this IServiceCollection services, IConfiguration configuration)
        {
            Mapping.MongoDBMapperConfiguration.RegisterMongoDBMappings();

            var settings = new DatabaseSettings();
            configuration.GetSection(nameof(DatabaseSettings)).Bind(settings);

            services.AddSingleton<IDatabaseSettings>(settings);

            services.AddTransient(typeof(IBaseEntityRepository<>), typeof(BaseEntityRepository<>));
            services.AddTransient(typeof(IAlternativesRepository<>), typeof(AlternativesRepository<>));
            services.AddTransient(typeof(IFiefForeinKeyRepository<>), typeof(FiefForeinKeyRepository<>));

            services.AddTransient<IGamesessionRepository, GamesessionRepository>();
            services.AddTransient<IFiefRepository, FiefRepository>();
            services.AddTransient<IGamesessionRepository, GamesessionRepository>();
            services.AddTransient<IIndustryRepository, IndustryRepository>();
            services.AddTransient<IStewardRepository, StewardRepository>();

            return services;
        }
    }
}
