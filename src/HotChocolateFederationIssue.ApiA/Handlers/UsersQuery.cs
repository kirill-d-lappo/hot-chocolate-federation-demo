using HotChocolate.Language;

namespace HotChocolateFederationIssue.ApiA.Handlers;

[ExtendObjectType(OperationType.Query)]
public class UsersQuery
{
  [UseOffsetPaging]
  [UseFiltering]
  [UseSorting]
  public IQueryable<User> AllUsers()
  {
    return Users.AsQueryable();
  }

  private static readonly User[] Users =
  [
    new()
    {
      Id = 1,
      Name = "user1",
    },
    new()
    {
      Id = 2,
      Name = "user2",
    },
    new()
    {
      Id = 3,
      Name = "user3",
    },
  ];
}
