using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonalSpike.Domain.Models;
using HexagonalSpike.Domain.Ports.Out;

namespace HexagonalSpike.Adapters.Out.Persistence.Repositories
{
	public class StudentRepository : IStudentRepository
	{
		public void AddStudent(Student student)
		{
			throw new NotImplementedException();
		}

		public Student GetStudent(string id)
		{
			throw new NotImplementedException();
		}

		public bool RemoveStudent(string id)
		{
			throw new NotImplementedException();
		}
	}
}
