using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
	public class Enrollment
	{
		public int Id { get; set; }
		public Guid IdUser { get; set; }
		public int IdCourse { get; set; }
		public User Users { get; set; }
		public Course Courses { get; set; }
	}
}