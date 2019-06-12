using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataProject.Models
{
	public class School
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid SchoolId { get; set; }
		[MaxLength(40)]
		[Required]
		public string Name { get; set; }
		[MaxLength(40)]
		[Required]
		public string State { get; set; }
		[MaxLength(40)]
		[Required]
		public string City { get; set; }

		public List<Student> Students { get; set; }
	}
}
