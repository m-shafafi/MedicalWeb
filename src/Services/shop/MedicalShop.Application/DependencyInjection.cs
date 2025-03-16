using FluentValidation;
using Mapster;
using Medicals.Application.Behaviors;
using MedicalShop.Application.Mappings;
using MedicalShop.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MedicalShop.Application
{
    public static class DependencyInjection
    {
        //public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddMediatR(cf =>
        //    {
        //        cf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        //        cf.AddOpenBehavior(typeof(ValidationBehavior<,>));
        //    });
            
        //    services.AddDbContext<ApplicationDbContext>(options =>
        //                options.UseSqlServer(configuration.GetConnectionString("Server=database.server,1433;Database=MedicalsDb;User Id=sa;Password=SuperPassword123;TrustServerCertificate=True;")));

        //    MappingConfig.Configure();
        //    var config = TypeAdapterConfig.GlobalSettings;
        //    config.Scan(Assembly.GetExecutingAssembly());
        //    services.AddSingleton(config);

        //    services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        //    return services;
       // }
    }
}
