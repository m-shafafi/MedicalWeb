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

builder.Services.AddGraphQL().AddSystemTextJson();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseGraphQL<AppSchema>();
app.UseGraphQLGraphiQL("/ui/graphql");
app.UseAuthorization();

app.MapControllers();

app.Run();