using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HexagonalSpike.Domain.Models;

namespace HexagonalSpike.Domain.Ports.Out
{
	public interface IStudentRepository
	{
		void AddStudent(Student student);
		Student GetStudent(string id);
		bool RemoveStudent(string id);
	}
}
