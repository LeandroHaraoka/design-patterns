using MediatR;
using MediatRExample.Variables;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace MediatRExample
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
                .ConfigureApiBehaviorOptions(CustomApiBehaviorOptions.Options);
          
            services.AddScoped<TemperatureHandler>();
            services.AddScoped<PressureHandler>();
            services.AddScoped<VolumeHandler>();
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

        public void Configure(IApplicationBuilder builder, IWebHostEnvironment environment)
        {
            if (!environment.IsDevelopment())
                builder.UseHsts();

            builder.UseRouting();

            builder.UseHttpsRedirection();

            builder.UseEndpoints(endpoints => endpoints.MapControllers());
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
}
