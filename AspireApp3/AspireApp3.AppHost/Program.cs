var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

//it is a postgres database with pgadmin
var postgres = builder.AddPostgres("postgres").WithPgAdmin();
// it is a postgres database with data volume
var postgresdb = postgres.WithDataVolume()
    .AddDatabase("UserDatabase");

var apiService = builder.AddProject<Projects.AspireApp3_ApiService>("apiservice")
    .WithReference(postgresdb); // reference to the postgres database


builder.AddProject<Projects.AspireApp3_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
