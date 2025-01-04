using MedicalShop.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace MedicalShop.Api
{
    public static class ServiceRegistery
    {
        public static IServiceCollection AddServiceRegistery(this WebApplicationBuilder builder) {
           builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDbContext>(option =>
                                        option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

            return builder.Services;
        }
    }
}
