using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using CodesAndDragons.Application.AutoMapper;
using System;

namespace CodesAndDragons.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(RequestModelToPlayerMapperProfile));
        }
    }
}
