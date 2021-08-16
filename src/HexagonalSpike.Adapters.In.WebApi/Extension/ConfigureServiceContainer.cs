using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models; //using HexagonalSpike.Persistence.Adapter.Context;

namespace HexagonalSpike.Adapters.In.WebApi.Extension
{
	public static class ConfigureServiceContainer
	{
		public static void AddSwaggerOpenAPI(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddSwaggerGen(setupAction =>
			{
				setupAction.SwaggerDoc(
					"OpenAPISpecification",
					new OpenApiInfo
					{
						Title = "Hexagonal Architecture API",
						Version = "1",
						Description = "",
					});
				//setupAction.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				//{
				//	Type = SecuritySchemeType.Http,
				//	Scheme = "bearer",
				//	BearerFormat = "JWT",
				//	Description = $"Input your Bearer token in this format - Bearer token to access this API",
				//});
				//setupAction.AddSecurityRequirement(new OpenApiSecurityRequirement
				//{
				//	{
				//		new OpenApiSecurityScheme
				//		{
				//			Reference = new OpenApiReference
				//			{
				//				Type = ReferenceType.SecurityScheme,
				//				Id = "Bearer",
				//			},
				//		}, new List<string>()
				//	},
				//});
				//var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				//var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);
				//setupAction.IncludeXmlComments(xmlCommentsFullPath);
			});
		}

		public static void AddApiVersion(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddApiVersioning(config =>
			{
				config.DefaultApiVersion = new ApiVersion(1, 0);
				config.AssumeDefaultVersionWhenUnspecified = true;
				config.ReportApiVersions = true;
			});
		}

		//public static void AddHealthCheck(this IServiceCollection serviceCollection)
		//{
		//	serviceCollection.AddHealthChecks()
		//	   .AddDbContextCheck<ApplicationDbContext>(name: "Application DB Context", failureStatus: HealthStatus.Degraded)
		//	   .AddUrlGroup(new Uri("https://amitpnk.github.io/"), name: "My personal website", failureStatus: HealthStatus.Degraded);

		//	serviceCollection.AddHealthChecksUI(setupSettings: setup =>
		//	{
		//		setup.AddHealthCheckEndpoint("Basic Health Check", $"/healthz");
		//	});
		//}
	}
}
