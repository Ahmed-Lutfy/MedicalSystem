using Medical.Application.Automapper;
using Medical.Domain.Interface;
using Medical.Infrastructure.Model;
using Medical.Infrastructure.Prsistance.Data;
using Medical.Infrastructure.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.Configuration
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrustructureService(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                    .AddEntityFrameworkStores<ApplicationDBContext>()
                    .AddDefaultTokenProviders();
            //services.AddIdentity<ApplicationUser, IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDBContext>()
            //    .AddDefaultTokenProviders();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddAutoMapper(typeof(UserProfile).Assembly);
            return services;
        }
      
    }
}
