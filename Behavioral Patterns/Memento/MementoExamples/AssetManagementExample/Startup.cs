using AssetManagementExample.Accruals;
using AssetManagementExample.Assets;
using Assets;
using AssetManagementExample.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AssetManagementExample
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddControllers()
                .AddNewtonsoftJson(CustomSerializerOptions.Options)
                .ConfigureApiBehaviorOptions(CustomApiBehaviorOptions.Options);

            services.AddSingleton<IRepository<Movement>, MovementRepository>();
            services.AddSingleton<IMementoRepository, AssetRepository>();
            services.AddSingleton<IAssetManager, AssetManager>();
            services.AddSingleton<Asset>();
            services.AddSingleton<CareTaker>();

            services.AddDocumentation();
        }

        public void Configure(IApplicationBuilder builder, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
                builder.UseDeveloperExceptionPage();

            builder.UseHttpsRedirection();

            builder.UseRouting();

            builder.UseDocumentation();
            builder.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public static class CustomApiBehaviorOptions
    {
        public static void Options(ApiBehaviorOptions options)
        {
            options.InvalidModelStateResponseFactory = OnInvalidModelStateResponse;
        }

        private static IActionResult OnInvalidModelStateResponse(
            ActionContext context)
        {
            return new BadRequestObjectResult(context.ModelState);
        }
    }

    public static class CustomSerializerOptions
    {
        public static void Options(MvcNewtonsoftJsonOptions options)
        {
            options.SerializerSettings.Converters.Add(new StringEnumConverter());
            options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        }
    }
}
