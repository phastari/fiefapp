using fiefapp.entities;
using fiefapp.graphql.Types;
using fiefapp.services.Interfaces;
using GraphQL;
using GraphQL.Types;
using System;

namespace fiefapp.graphql
{
    public partial class RootQueries
    {
        partial void AddBuildingFields(IBaseEntityRepository<Building> repository)
        {
            FieldAsync<ListGraphType<BuildingType>>(
                name: "buildings", 
                resolve: async context =>
                {
                    return await repository.GetListAsync();
                }
            );

            FieldAsync<BuildingType>(
                name: "building",
                arguments: new QueryArguments(
                    new QueryArgument<GuidGraphType>
                    {
                        Name = "id"
                    }
                ),
                resolve: async context =>
                {
                    var id = context.GetArgument<Guid>("id");

                    return await repository.GetByIdAsync(id);
                }
            );
        }
    }
}
