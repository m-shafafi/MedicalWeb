using Medicals.Presentation.Modules;
using Products.Application;
using Products.Infrastructure;
using Products.Presentation;
using Products.Presentation.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", policyBuilder =>
    {
        policyBuilder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:5000");
    });
});

builder.Services.AddApplication(builder.Configuration);
builder.Services.AddExceptionHandler<ExceptionHandler>();
builder.AddServiceRegistery();
builder.AddInfrastructureServices();
builder.AddApplicationServices();
builder.AddMessagingConfiguration();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
     using var serviceScope = app.Services.CreateScope();
    using var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.AddMedicalsEndpoints();
app.Run();
