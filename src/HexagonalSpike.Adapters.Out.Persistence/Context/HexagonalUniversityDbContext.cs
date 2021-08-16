using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonalSpike.Adapters.Out.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HexagonalSpike.Adapters.Out.Persistence.Context
{
	public class HexagonalUniversityDbContext : DbContext
	{
		public HexagonalUniversityDbContext()
		{
		}

		public HexagonalUniversityDbContext(DbContextOptions<HexagonalUniversityDbContext> options) : base(options)
		{
		}

		public DbSet<Enrollment> Enrollments { get; set; }

		public DbSet<Student> Students { get; set; }

		public DbSet<Class> Classes { get; set; }
	}
}
