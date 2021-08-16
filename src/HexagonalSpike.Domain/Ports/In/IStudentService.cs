using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HexagonalSpike.Domain.Models;

namespace HexagonalSpike.Domain.Ports.In
{
	public interface IStudentService
	{
		IEnumerable<Student> GetStudents(string classId);
		void EnrollStudent(string studentId, string classId);
	}
}
