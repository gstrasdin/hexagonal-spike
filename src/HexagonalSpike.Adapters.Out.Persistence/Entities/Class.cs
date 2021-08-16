﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonalSpike.Adapters.Out.Persistence.Entities
{
	public class Class
	{
		[Key]
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
