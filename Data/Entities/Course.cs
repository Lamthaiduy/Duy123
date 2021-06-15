using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
	public class Course
	{
		public int Id { get; set; }
		public int IdUser { get; set; }
		public string Name { get; set; }
		public int IdTopic { get; set; }
		public int IdCourseCategory { get; set; }
		public string Description { get; set; }
		public Topic Topics { get; set; }
		public CourseCategory CourseCategories { get; set; }
		public List<Enrollment> Enrollments { get; set; }
	}
}