namespace HotChocolateFederationDemo.Shared;

public static class WebApplicationExtensions
{
  public static void RunGql<TApp>(this TApp app, string[] args)
    where TApp : IHost, IEndpointRouteBuilder
  {
    app.MapGraphQL();

    app.MapRedirect("/graphql");

    app.RunWithGraphQLCommands(args);
  }
}
