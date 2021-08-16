using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonalSpike.Adapters.Out.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalSpike.Adapters.Out.Persistence.Extensions
{
	public static class PersistenceExtensions
	{
		public static void AddPersistence(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddDbContext<HexagonalUniversityDbContext>(options =>
				options.UseInMemoryDatabase("HexagonalUniversityInMemoryDatabase"));
		}
	}
}
