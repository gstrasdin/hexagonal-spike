using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonalSpike.Adapters.In.WebApi.Extension;
using HexagonalSpike.Adapters.Out.Persistence.Extensions;
using HexagonalSpike.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Bootstrap
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();
			Configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();

			services.AddPersistence();

			//services.AddDomain();

			services.AddSwaggerOpenAPI();

			services.AddApiVersion();

			//services.AddHealthCheck();

		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory log)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			//app.UseHttpsRedirection();

			app.UseRouting();

			//app.UseAuthentication();

			//app.UseAuthorization();

			app.UseSwaggerConfig();

			//app.UseHealthCheck();

			log.AddSerilog();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
