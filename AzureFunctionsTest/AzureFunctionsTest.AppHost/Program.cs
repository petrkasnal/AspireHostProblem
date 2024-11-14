using Aspire.Hosting.Azure;
using Azure.Provisioning.Storage;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureFunctionsProject<Projects.AzureFunctionsTest_Functions>("funcapp");

builder.Build().Run();