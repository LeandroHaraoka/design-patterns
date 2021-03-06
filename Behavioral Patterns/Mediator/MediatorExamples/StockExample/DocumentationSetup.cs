﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NSwag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockExample
{
    public static class DocumentationSetup
    {
        public static IServiceCollection AddDocumentation(
            this IServiceCollection services)
        {
            services.AddOpenApiDocument((settings, provider) =>
            {
                settings.Title = "Stock Exchange Api";
                settings.Description = "This application executes Stock Exchange transactions.";
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
