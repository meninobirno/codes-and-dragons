using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CodesAndDragons.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMapping(IServiceProvider provider)
        {
            var mpc = new MapperConfiguration(cfg => {
                cfg.AddProfile(new RequestModelToPlayerMapperProfile());
                cfg.ConstructServicesUsing(type => ActivatorUtilities.CreateInstance(provider, type));
            });

            return mpc;
        }
    }
}
