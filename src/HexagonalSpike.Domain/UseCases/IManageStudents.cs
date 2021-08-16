using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HexagonalSpike.Domain.Models;

namespace HexagonalSpike.Domain.UseCases
{
	public interface IManageStudents
	{
		IEnumerable<Student> GetStudents(string classId);
		bool EnrollStudent(string studentId, string classId);
	}
}
