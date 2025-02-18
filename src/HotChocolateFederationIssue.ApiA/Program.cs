using HotChocolateFederationIssue.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureGql()
  .AddApiATypes()
  ;

var app = builder.Build();

app.RunGql(args);
