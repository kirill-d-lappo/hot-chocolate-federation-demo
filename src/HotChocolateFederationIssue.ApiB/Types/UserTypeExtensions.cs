namespace HotChocolateFederationIssue.ApiB.Types;

[ExtendObjectType(typeof(User))]
public class UserTypeExtensions
{
  [Requires("name")]
  public string ExtendedName([Parent] User user)
  {
    var name = user.Name;
    if (name == null)
    {
      return "unknown name";
    }

    return $"{user.Id}--{name}";
  }
}
