#:package Aspire.Hosting.PostgreSQL@13.2.2
#:sdk Aspire.AppHost.Sdk@13.2.2
#:project Prism.Api/Prism.Api.csproj

var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres");
var prism = postgres.AddDatabase("prism");

builder.AddProject<Projects.Prism_Api>("api")
    .WithReference(prism)
    .WaitFor(postgres);

builder.Build().Run();
