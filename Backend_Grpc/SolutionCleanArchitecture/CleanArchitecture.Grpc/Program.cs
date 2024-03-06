using CleanArchitecture.Grpc.Services;
using CleanArchitecture.Infraestructure.IoC;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
// Add services to the container.
builder.Services.AddGrpc();
DependencyContainer.RegisterServices(builder.Services, configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<ProductsAppService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
