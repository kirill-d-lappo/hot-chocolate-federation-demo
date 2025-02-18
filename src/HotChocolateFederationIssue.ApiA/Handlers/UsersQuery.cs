using HotChocolate.Language;

namespace HotChocolateFederationIssue.ApiA.Handlers;

[ExtendObjectType(OperationType.Query)]
public class UsersQuery
{
  public IEnumerable<User> AllUsers()
  {
    return Users;
  }

  private static readonly User[] Users =
  [
    new()
    {
      Id = 1,
      Name = "user1",
      Numbers = [1, 2, 3, 4,],
      Age = 42,
      PersonalKey = Guid.Parse("E35F3D0A-12D9-4617-9898-5F1D6B295EC1"),
      Longs =
      [
        new LongInside
        {
          Value = 42,
        },
      ],
    },
    new()
    {
      Id = 2,
      Name = "user2",
      Numbers = [5, 6, 7, 8,],
      Age = 33,
      PersonalKey = Guid.Parse("5692008E-A982-4D0E-9D73-BE12B1E666A5"),
      Longs =
      [
        new LongInside
        {
          Value = 33,
        },
      ],
    },
    new()
    {
      Id = 3,
      Name = "user3",
      Numbers = [9, 10, 11, 12,],
      Age = 7,
      PersonalKey = Guid.Parse("B13236E7-39A8-4CC1-8F0D-043BF814B99A"),
      Longs =
      [
        new LongInside
        {
          Value = 7,
        },
      ],
    },
  ];
}
