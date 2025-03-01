using MedicalShop.Domain.UnitOfWork.Product;
using MedicalShop.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace MedicalShop.Api
{
    public static class ServiceRegistery
    {
        public static IServiceCollection AddServiceRegistery(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });
            return builder.Services;
        }
        public static IServiceCollection AddInfrastructureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("MedicalWeb", optt =>
                 {
                optt.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:5050");
                 });
            });
            builder.Services.AddScoped<IReadUnitOfWork, ReadUnitOfWork>();
            builder.Services.AddScoped<IWriteUnitOfWork, WriteUnitOfWork>();

            return builder.Services;
        }
    }
}
