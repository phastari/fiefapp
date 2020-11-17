using fiefapp.graphql.Services.BuildingAlternative;
using GraphQL;
using GraphQL.Server;
using GraphQL.SystemTextJson;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace fiefapp.graphql
{
    public static class DependencyInjection
    {
        public static IServiceCollection DI_GraphQL(this IServiceCollection services)
        {
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();

            services.AddSingleton<IBuildingAlternativeSubscriptionService, BuildingAlternativeSubscriptionService>();

            services.AddSingleton<RootQueries>();
            services.AddSingleton<RootMutations>();
            services.AddSingleton<RootSubscription>();
            services.AddSingleton<RootSchema>();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            })
            .AddErrorInfoProvider(options => options.ExposeExceptionStackTrace = true)
            .AddSystemTextJson()
            .AddUserContextBuilder(httpContext => new GraphQLUserContext { User = httpContext.User })
            .AddWebSockets()
            .AddDataLoader()
            .AddGraphTypes(typeof(RootSchema));

            return services;
        }

        public static IApplicationBuilder DI_UseGraphQL(this IApplicationBuilder application)
        {
            application.UseWebSockets();
            application.UseGraphQLWebSockets<RootSchema>();
            application.UseGraphQL<RootSchema>();
            application.UseGraphQLPlayground();

            return application;
        }
    }
}
