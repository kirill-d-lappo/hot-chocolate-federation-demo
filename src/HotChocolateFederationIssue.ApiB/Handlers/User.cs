namespace HotChocolateFederationIssue.ApiB.Handlers;

[ExtendServiceType]
public class User
{
  [GraphQLKey]
  public long Id { get; set; }

  [External]
  public string Name { get; set; }

  [External]
  public long Age { get; set; }

  [External]
  public Guid PersonalKey { get; set; }

  // FixMe [2025-02-18 klappo] not working
  [External]
  public IEnumerable<long> Numbers { get; set; }

  // FixMe [2025-02-18 klappo] not working
  [External]
  public IEnumerable<LongInside> Longs { get; set; }

  // Note [2025-02-18 klappo] specify all fields you want to pass to methods in UserTypeExtensions.cs
  // Note [2025-02-18 klappo] also add names of those field into Required attribute field set
  // Note [2025-02-18 klappo] External and Requires are tightly connected:
  // Note [2025-02-18 klappo] * you need specify External when field is added to any Requires field set
  // Note [2025-02-18 klappo] * you must remove External when field is NOT added to ANY Requires field set
  // FixMe [2025-02-18 klappo] as of 2025-02-18 collection field is always null here
  [ReferenceResolver]
  public static User ResolveReference(
    long id,
    string name,
    long age,
    Guid personalKey,
    IEnumerable<long> numbers,
    IEnumerable<LongInside> longs
  )
  {
    return new User
    {
      Id = id,
      Name = name,
      Numbers = numbers,
      PersonalKey = personalKey,
      Age = age,
      Longs = longs,
    };
  }
}
