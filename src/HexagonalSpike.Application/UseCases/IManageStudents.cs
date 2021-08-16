using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonalSpike.Domain.Models;
using HexagonalSpike.Domain.Ports.Out;
using HexagonalSpike.Domain.UseCases;

namespace HexagonalSpike.Application.UseCases
{
	public class ManageStudents : IManageStudents
	{
		private readonly IStudentRepository _studentRepository;
		private readonly IEnrollmentRepository _enrollmentRepository;

		public ManageStudents(IStudentRepository studentRepository, IEnrollmentRepository enrollmentRepository)
		{
			_studentRepository = studentRepository;
			_enrollmentRepository = enrollmentRepository;
		}

		public IEnumerable<Student> GetStudents(string classId)
		{
			return _enrollmentRepository.GetStudents(classId);
		}

		public bool EnrollStudent(string studentId, string classId)
		{
			var enrolled = _enrollmentRepository.GetClasses(studentId).Any(e => e.Cid.Equals(classId));
			if (enrolled) return false;
		
			return _enrollmentRepository.EnrollStudent(studentId, classId);
		}
	}
}
