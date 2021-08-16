using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonalSpike.Domain.Models;
using HexagonalSpike.Domain.Ports.Out;

namespace HexagonalSpike.Adapters.Out.Persistence.Repositories
{
	public class EnrollmentRepository : IEnrollmentRepository
	{
		public IEnumerable<Student> GetStudents(string classId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Class> GetClasses(string studentId)
		{
			throw new NotImplementedException();
		}

		public bool EnrollStudent(string studentId, string classId)
		{
			throw new NotImplementedException();
		}

		public bool UnenrollStudent(string studentId, string classId)
		{
			throw new NotImplementedException();
		}
	}
}
