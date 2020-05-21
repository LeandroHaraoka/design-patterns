using AutoMapper;
using System;

namespace BookTraderExample.Extensions
{
    public static class ObjectExtensions
    {
        public static TDestination MapTo<TDestination>(this object obj)
        {
            var mapper = ServiceLocator.GetService<IMapper>();
            return mapper.Map<TDestination>(obj);
        }
    }

    public class ServiceLocator
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static TService GetService<TService>() =>
            (TService)ServiceProvider.GetService(typeof(TService));
    }
}
