namespace HotChocolateFederationDemo.ApiB.Handlers;

[ExtendObjectType(typeof(User))]
public class UserTypeExtensions
{
  [Requires("name age numbers personalKey")]
  public string CollectionOfDefaultTypeExample([Parent] User user)
  {
    if (user == null)
    {
      return "user is null, can't create extended name";
    }

    var name = user.Name;
    if (name == null)
    {
      return "user NAME is null, can't create extended name";
    }

    var age = user.Age;
    if (age <= 0)
    {
      return "user AGE is not positive, can't create extended name";
    }

    var pk = user.PersonalKey;
    if (pk == Guid.Empty)
    {
      return "user PERSONAL KEY is default, can't create extended name";
    }

    var magicNumbers = user.Numbers;
    if (magicNumbers == null)
    {
      return "user MAGIC NUMBERS are null, can't create extended name";
    }

    return $"{user.Id}--{name}--{age}--{pk}--{string.Join("-", magicNumbers)}";
  }

  [Requires("name age personalKey")]
  public string SimpleTypesOnlyExample([Parent] User user)
  {
    if (user == null)
    {
      return "user is null, can't create extended name";
    }

    var name = user.Name;
    if (name == null)
    {
      return "user NAME is null, can't create extended name";
    }

    var age = user.Age;
    if (age <= 0)
    {
      return "user AGE is not positive, can't create extended name";
    }

    var pk = user.PersonalKey;
    if (pk == Guid.Empty)
    {
      return "user PERSONAL KEY is default, can't create extended name";
    }

    return $"{user.Id}--{name}--{age}--{pk}";
  }

  [Requires("longs{value}")]
  public string CollectionOfRefType([Parent] User user)
  {
    if (user == null)
    {
      return "user is null, can't create extended name";
    }

    var longs = user.Longs;
    if (longs == null)
    {
      return "user LONGS  are null, can't create extended name";
    }

    return $"User longs: {string.Join(",", longs)}";
  }

  [Requires("numbersString")]
  public string WorkaroundForNumbers([Parent] User user)
  {
    if (user == null)
    {
      return "user is null, can't create extended name";
    }

    var numbersString = user.NumbersString;
    if (string.IsNullOrWhiteSpace(numbersString))
    {
      return "user NumbersString is empty, can't create extended name";
    }

    // Note [2025-02-19 klappo] splitting and parsing back and forth just for an example
    var numbers = numbersString
      .Split(';')
      .Select(long.Parse)
      .ToList();

    return $"Numbers are: {string.Join(", ", numbers)}";
  }
}
