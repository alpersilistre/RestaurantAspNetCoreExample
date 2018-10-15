using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RestaurantAspNetCore.Services;

namespace RestaurantAspNetCore
{
	public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddSingleton<IGreeter, Greeter>();
			services.AddSingleton<IRestaurantData, InMemoryRestaurantData>();
			services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IGreeter greeter, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

			//app.UseDefaultFiles();
			app.UseStaticFiles();

			app.UseMvc(ConfigureRoutes);

			//app.UseFileServer();

			//app.Use(next =>
			//{
			//	return async context =>
			//	{
			//		logger.LogInformation("Request incoming");

			//		if (context.Request.Path.StartsWithSegments("/mym"))
			//		{
			//			await context.Response.WriteAsync("Hit!!");
			//			logger.LogInformation("Request handled");
			//		}
			//		else
			//		{
			//			await next(context);
			//			logger.LogInformation("Request outcoming");
			//		}
			//	};
			//});

			//app.UseWelcomePage(new WelcomePageOptions
			//{
			//	Path = "/wp"
			//});

			app.Run(async (context) =>
            {
				//throw new Exception("error!");

				var greeting = greeter.GetMessageOfTheDay();

				context.Response.ContentType = "text/plain";
				await context.Response.WriteAsync($"Not found!");

				//await context.Response.WriteAsync($"{greeting} : {env.EnvironmentName}");
			});
        }

		private void ConfigureRoutes(IRouteBuilder routeBuilder)
		{
			// /Home/Index

			routeBuilder.MapRoute("Default", 
				"{controller=Home}/{action=Index}/{id?}");
		}
	}
}
