using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace fiefapp.graphql
{
    public class RootSchema : Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();

            Description = "Fiefapp schema";
        }
    }
}
