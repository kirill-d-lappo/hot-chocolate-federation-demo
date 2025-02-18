namespace HotChocolateFederationDemo.ApiA.Handlers;

public class User
{
  [GraphQLKey]
  public long Id { get; set; }

  public string Name { get; set; }

  /// <summary>
  /// Magic numbers
  /// </summary>
  public IEnumerable<long> Numbers { get; set; }

  public Guid PersonalKey { get; set; }

  public long Age { get; set; }

  public IEnumerable<LongInside> Longs { get; set; }
}
