using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StockExample.Brokers;
using StockExample.Brokers.BrokerRepositories;
using System.Reflection;

namespace StockExample
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

            services.AddSingleton<BlueBroker>();
            services.AddSingleton<GreenBroker>();
            services.AddSingleton<RedBroker>();

            services.AddSingleton<BlueBrokerRepository>();
            services.AddSingleton<GreenBrokerRepository>();
            services.AddSingleton<RedBrokerRepository>();

            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

        public void Configure(IApplicationBuilder builder, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
                builder.UseDeveloperExceptionPage();

            builder.UseHttpsRedirection();

            builder.UseRouting();

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
}
