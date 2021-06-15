using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
	public class AcademicLevel
	{
		public int Id { get; set; }

		public string ProgrammingLanguage { get; set; }
		public int TOEICScore { get; set; }
		public int ExperienceDetails { get; set; }
		public string Department { get; set; }
		public string Location { get; set; }
		public List<User> Users { get; set; }
	}
}