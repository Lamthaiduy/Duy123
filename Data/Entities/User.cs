using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
	public class User : IdentityUser<Guid>
	{
		public int AcademicLevelId { get; set; }
		public string FullName { get; set; }
		public bool Sex { set; get; }
		public int Age { get; set; }
		public DateTime DoB { get; set; }
		public AcademicLevel AcademicLevels { get; set; }
		public List<Enrollment> Enrollments { get; set; }
	}
}