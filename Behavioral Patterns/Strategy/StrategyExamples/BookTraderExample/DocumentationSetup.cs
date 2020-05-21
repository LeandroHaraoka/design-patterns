using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BookTraderExample
{
    public static class DocumentationSetup
    {
        public static IServiceCollection AddDocumentation(
            this IServiceCollection services)
        {
            services.AddOpenApiDocument((settings, provider) =>
            {
                settings.Title = "Asset Management Api";
                settings.Description = "This application manages a Financial Asset life cycle.";
                settings.GenerateXmlObjects = true;
            });
            return services;
        }

        public static IApplicationBuilder UseDocumentation(
            this IApplicationBuilder builder)
        {
            builder
                .UseOpenApi()
                .UseReDoc((settings) =>
                {
                    settings.Path = "/docs";
                })
                .UseSwaggerUi3((settings) =>
                {
                    settings.Path = "/swagger";
                });

            return builder;
        }
    }
}
