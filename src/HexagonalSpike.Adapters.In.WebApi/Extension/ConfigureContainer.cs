using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
//using HealthChecks.UI.Client;

namespace HexagonalSpike.Adapters.In.WebApi.Extension
{
	public static class ConfigureContainer
	{
		public static void UseSwaggerConfig(this IApplicationBuilder app)
		{
			app.UseSwagger();

			app.UseSwaggerUI(setupAction =>
			{
				setupAction.SwaggerEndpoint("/swagger/OpenAPISpecification/swagger.json", "Hexagonal Architecture API");
				setupAction.RoutePrefix = "OpenAPI";
			});
		}

		//public static void UseHealthCheck(this IApplicationBuilder app)
		//{
		//	app.UseHealthChecks("/healthz", new HealthCheckOptions
		//	{
		//		Predicate = _ => true,
		//		ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse,
		//		ResultStatusCodes =
		//		{
		//			[HealthStatus.Healthy] = StatusCodes.Status200OK,
		//			[HealthStatus.Degraded] = StatusCodes.Status500InternalServerError,
		//			[HealthStatus.Unhealthy] = StatusCodes.Status503ServiceUnavailable,
		//		},
		//	}).UseHealthChecksUI(setup =>
		//	{
		//		setup.ApiPath = "/healthcheck";
		//		setup.UIPath = "/healthcheck-ui";
		//	});
		//}
	}
}
