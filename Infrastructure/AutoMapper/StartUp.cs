﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.AutoMapper
{
    public static class StartUp
    {
        public static IServiceCollection AddAutoMappingConfig(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetAssembly(typeof(Automapping)));
            return services;
        }
    }
}
