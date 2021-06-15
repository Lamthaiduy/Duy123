using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
	public class CourseCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Course> Courses { get; set; }
	}
}