namespace HotChocolateFederationIssue.ApiB.Types;

[ExtendServiceType]
public class User
{
  [GraphQLKey]
  public long Id { get; set; }

  [External]
  [IsProjected(true)]
  public string Name { get; set; }

  [ReferenceResolver]
  public static User ResolveReference(long id)
  {
    return new User
    {
      Id = id,
    };
  }
}
