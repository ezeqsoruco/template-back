﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public static class ServiceExtension
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DB");
            services.AddDbContext<DataContext>(opt => opt.UseSqlServer(connectionString));
        }
    }
}
