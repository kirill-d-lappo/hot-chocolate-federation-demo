namespace HotChocolateFederationIssue.ApiA.Handlers;

public class User
{
  [GraphQLKey]
  public long Id { get; set; }

  public string Name { get; set; }
}
