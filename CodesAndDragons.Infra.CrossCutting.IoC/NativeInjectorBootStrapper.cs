using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace CodesAndDragons.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper 
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<Random>();
        }
    }
}
