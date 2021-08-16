using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HexagonalSpike.Domain.Models;

namespace HexagonalSpike.Domain.Ports.Out
{
	public interface IClassRepository
	{
		void AddClass(Class @class);
		Student GetClass(string id);
		bool RemoveClass(string id);
	}
}
