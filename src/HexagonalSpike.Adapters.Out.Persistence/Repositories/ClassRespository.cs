using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonalSpike.Domain.Models;
using HexagonalSpike.Domain.Ports.Out;

namespace HexagonalSpike.Adapters.Out.Persistence.Repositories
{
	public class ClassRespository : IClassRepository
	{
		public void AddClass(Class @class)
		{
			throw new NotImplementedException();
		}

		public Student GetClass(string id)
		{
			throw new NotImplementedException();
		}

		public bool RemoveClass(string id)
		{
			throw new NotImplementedException();
		}
	}
}
