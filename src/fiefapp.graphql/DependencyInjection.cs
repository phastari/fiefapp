using fiefapp.graphql.Types;
using GraphQL;
using GraphQL.Server;
using GraphQL.SystemTextJson;
using GraphQL.Types;
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
            services.AddSingleton<BuildingAlternativeType>();
            services.AddSingleton<RootQuery>();
            services.AddSingleton<ISchema, RootSchema>();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            })
            .AddErrorInfoProvider(options => options.ExposeExceptionStackTrace = true)
            .AddSystemTextJson()
            .AddUserContextBuilder(httpContext => new GraphQLUserContext { User = httpContext.User });

            return services;
        }

        public static IApplicationBuilder DI_UseGraphQL(this IApplicationBuilder application)
        {
            application.UseGraphQL<ISchema>();
            application.UseGraphQLPlayground();

            return application;
        }
    }
}
