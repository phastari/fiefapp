﻿using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace fiefapp.graphql
{
    public class RootSchema : Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQueries>();
            Mutation = serviceProvider.GetRequiredService<RootMutations>();
            Subscription = serviceProvider.GetRequiredService<RootSubscription>();
        }
    }
}
