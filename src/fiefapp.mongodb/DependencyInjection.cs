﻿using fiefapp.mongodb.Repositories.BuildingAlternative;
using fiefapp.mongodb.Repositories.SelectionAlternatives;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace fiefapp.mongodb
{
    public static class DependencyInjection
    {
        public static IServiceCollection DI_MongoDB(this IServiceCollection services, IConfiguration configuration)
        {
            var settings = new DatabaseSettings();
            configuration.GetSection(nameof(DatabaseSettings)).Bind(settings);

            services.AddSingleton<IDatabaseSettings>(settings);

            services.AddTransient<IBuildingAlternativeRepository, BuildingAlternativeRepository>();
            services.AddTransient<ISelectionAlternativesRepository, SelectionAlternativesRepository>();

            return services;
        }
    }
}
