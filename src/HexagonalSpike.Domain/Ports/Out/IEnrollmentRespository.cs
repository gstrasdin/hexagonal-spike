using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HexagonalSpike.Domain.Models;

namespace HexagonalSpike.Domain.Ports.Out
{
	public interface IEnrollmentRepository
	{
		IEnumerable<Student> GetStudents(string classId);
		IEnumerable<Class> GetClasses(string studentId);
		bool EnrollStudent(string studentId, string classId);
		bool UnenrollStudent(string studentId, string classId);
	}
}
