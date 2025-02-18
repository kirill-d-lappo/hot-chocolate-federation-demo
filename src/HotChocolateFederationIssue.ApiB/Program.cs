using HotChocolateFederationIssue.ApiB.Handlers;
using HotChocolateFederationIssue.Shared;

var builder = WebApplication.CreateBuilder(args);

// have to specify User type manually to make it appear in schema
builder
  .ConfigureGql()
  .AddApiBTypes()
  .AddType<User>();

var app = builder.Build();

app.RunGql(args);
