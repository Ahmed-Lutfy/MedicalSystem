using Medical.Infrastructure.Prsistance.Data;
using Microsoft.EntityFrameworkCore;

namespace Medical.PL.API.Configuration
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddAPIService(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
