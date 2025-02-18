namespace HotChocolateFederationIssue.ApiB.Handlers;

[ExtendServiceType]
public class LongInside
{
  [External]
  public long Value { get; set; }

  public override string ToString()
  {
    return $"{{{Value.ToString()}}}";
  }
}
