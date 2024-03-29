global using FastEndpoints;
global using FluentValidation;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();

var app = builder.Build();

app.UseFastEndpoints();
app.UseSwaggerGen();
app.Run();
