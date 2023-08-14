using Infrastructure.AutoMapper;
using Infrastructure.Behaviour;
using Infrastructure.Implementation;
using Infrastructure.Persistance;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class StartUp
    {
        public static IServiceCollection AddInfrastructureConfig(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddAutoMappingConfig();
            services.AddMediatRConfig();
            services.AddServicesConfig();
            services.AddDbContextConfig(configuration);
            return services;
        }
    }
}
