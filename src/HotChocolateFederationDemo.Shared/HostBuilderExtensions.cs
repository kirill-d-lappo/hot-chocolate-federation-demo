using HotChocolate.Execution.Configuration;

namespace HotChocolateFederationDemo.Shared;

public static class HostBuilderExtensions
{
  public static IRequestExecutorBuilder ConfigureGql(this IHostApplicationBuilder builder)
  {
    return builder
      .Services
      .AddGraphQLServer()
      .AddQueryType()
      .AddQueryConventions()
      .AddMutationConventions()
      .AddFiltering()
      .AddProjections()
      .AddSorting()
      .AddApolloFederation(FederationVersion.Federation27);
  }
}
