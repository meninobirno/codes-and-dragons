using CodesAndDragons.Domain.Interfaces;
using CodesAndDragons.Infra.Data.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Runtime.Caching;

namespace CodesAndDragons.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper 
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<Random>();

            //Repositories
            services.AddScoped<ICacheRepository, CacheRepository>();
            services.AddScoped<IDiceRepository, DiceRepository>();

        }
    }
}
