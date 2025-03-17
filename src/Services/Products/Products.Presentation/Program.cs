using Products.Infrastructure;
using Products.Presentation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", policyBuilder =>
    {
        policyBuilder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:5000");
    });
});

builder.AddServiceRegistery();
builder.AddInfrastructureServices();
builder.AddApplicationServices();
builder.AddMessagingConfiguration();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    using var serviceScope = app.Services.CreateScope();
    using var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();
