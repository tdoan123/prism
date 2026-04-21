#:package Aspire.Hosting.MongoDB@13.2.2
#:package Aspire.Hosting.PostgreSQL@13.2.2
#:sdk Aspire.AppHost.Sdk@13.2.2
#:project Prism.Api/Prism.Api.csproj

var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres");
var prism = postgres.AddDatabase("prism");

var mongo = builder.AddMongoDB("mongo");
var prismMongoDb = mongo.AddDatabase("prismMongoDb");

builder.AddProject<Projects.Prism_Api>("api")
    .WithReference(prism)
    .WaitFor(postgres)
    .WithReference(prismMongoDb)
    .WaitFor(mongo);

builder.Build().Run();
