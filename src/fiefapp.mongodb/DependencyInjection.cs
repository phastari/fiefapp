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
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IGamesessionRepository, GamesessionRepository>();

            return services;
        }
    }
}
