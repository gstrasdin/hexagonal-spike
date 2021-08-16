using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HexagonalSpike.Domain.Models;
using HexagonalSpike.Domain.Ports.In;
using HexagonalSpike.Domain.UseCases;

namespace HexagonalSpike.Adapters.In.WebApi.Services
{
	public class StudentService : IStudentService
	{
		private readonly IManageStudents _studentManager;

		public StudentService(IManageStudents studentManager)
		{
			_studentManager = studentManager;
		}

		public IEnumerable<Student> GetStudents(string classId)
		{
			return _studentManager.GetStudents(classId);
		}

		public void EnrollStudent(string studentId, string classId)
		{
			_studentManager.EnrollStudent(studentId, classId);
		}
	}
}
