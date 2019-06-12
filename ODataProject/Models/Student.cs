using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataProject.Models
{
	public class Student
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid StudentId { get; set; }
		[MaxLength(60)]
		[Required]
		public string Name { get; set; }
		[Required]
		[Range(0,150)]
		public int Score { get; set; }

		[ForeignKey("School")]
		public Guid SchoolId { get; set; }
		public School School { get; set; }
	}
}
