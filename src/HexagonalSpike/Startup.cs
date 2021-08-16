using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonalSpike.Domain;
using HexagonalSpike.DomainApi.Services;
using HexagonalSpike.Persistence.Adapter;
using HexagonalSpike.RestAdapter.Extension;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace HexagonalSpike
{
	public class Startup
	{
		public IConfiguration Configuration { get; }
		private AppSettings AppSettings { get; set; }

		public Startup(IConfiguration configuration)
		{
			Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();
			Configuration = configuration;

			AppSettings = new AppSettings();
			Configuration.Bind(AppSettings);
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();

			services.AddPersistence();

			services.AddDomain();

			services.AddSwaggerOpenAPI(AppSettings);

			services.AddApiVersion();

			//services.AddHealthCheck();

		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory log)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthentication();

			app.UseAuthorization();

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
