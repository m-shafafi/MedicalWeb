using GraphQL.Server;
using GraphQL.SystemTextJson;
using Products.Presentation;
using Products.Presentation.GQL;
using Products.Presentation.GQL.Mutations;
using Products.Presentation.GQL.Queries;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.AddServiceRegistery();

builder.AddInfrastructureServices();
builder.AddApplicationServices();
builder.AddMessagingConfiguration();

builder.Services.AddScoped<AppMutations>();
builder.Services.AddScoped<AppQueries>();
builder.Services.AddScoped<AppSchema>();



var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();
