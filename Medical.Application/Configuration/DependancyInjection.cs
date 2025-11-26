using Medical.Application.Automapper;
using Medical.Application.Service.Interface;
using Medical.Application.Service.ServiceClass;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Medical.Domain.Interface;

namespace Medical.Application.Configuration
{
    public static class DependancyInhection
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddAutoMapper(typeof(AppointmentProfile).Assembly);
            return services;
        }
    }
}
