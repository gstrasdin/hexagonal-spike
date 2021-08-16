using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Bootstrap
{
	class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args)
		{
			return Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					//webBuilder.ConfigureKestrel(options =>
					//{
					//	options.ConfigureEndpointDefaults(listenOptions =>
					//	{
					//		listenOptions.EndPoint. = new UriEndPoint("http://localhost.com:5000/");
					//	});
					//});
					webBuilder.UseContentRoot(@"C:\GitHub\hexagonal-spike\src\HexagonalSpike.Adapters.In.WebApi\bin\Debug\net5.0");
					webBuilder.UseStartup<Startup>();
				});
		}
	}
}
