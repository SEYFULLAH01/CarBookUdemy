﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Application.Services
{
    public static class ServiceRegistiration
    {
        public static void AddApplicationService
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(typeof
                (ServiceRegistiration).Assembly));

        }
    }
}
