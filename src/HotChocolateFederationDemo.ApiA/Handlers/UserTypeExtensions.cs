namespace HotChocolateFederationDemo.ApiA.Handlers;

[ExtendObjectType(typeof(User))]
public class UserTypeExtensions
{
  /// <summary>
  /// Workaround for <see cref="User.Numbers"/> until the issue is fixed
  /// </summary>
  public string NumbersString([Parent] User user)
  {
    if (user == null)
    {
      return null;
    }

    var numbers = user.Numbers;
    if (numbers is not { Count: > 0, })
    {
      return null;
    }

    return string.Join(";", numbers);
  }
}
