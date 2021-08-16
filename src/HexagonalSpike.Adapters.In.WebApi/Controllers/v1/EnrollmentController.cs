using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonalSpike.Domain.Ports.In;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalSpike.Adapters.In.WebApi.Controllers.v1
{
	[ApiController]
	[Route("api/v{version:apiVersion}/[controller]")]
	public class EnrollmentController : ControllerBase
	{
		private readonly IStudentService _service;

		public EnrollmentController(IStudentService service)
		{
			_service = service;
		}

		// GET: api/deal
		[HttpGet]
		public IActionResult GetStudents(string classId)
		{
			var students = _service.GetStudents(classId);
			return Ok(students);
		}

		// GET: api/deal/1
		[HttpPost]
		[Route("{studentId}/{classId}", Name = "GetDeal")]
		public IActionResult Enroll(string studentId, string classId)
		{
			_service.EnrollStudent(studentId, classId);
			return Ok();
		}
	}
}
