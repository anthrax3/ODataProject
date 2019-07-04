using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ODataProject.Models.Seed
{
    public static class SeedingData
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			var schoolList = new List<School>()
			{
					new School { SchoolId = Guid.NewGuid(), Name = "UABC - Mexicali", City = "Mexicali", State = "Baja California" },
					new School { SchoolId = Guid.NewGuid(), Name = "TECNOLOGICO UNIVERSIDAD - Mexicali", City = "Mexicali", State = "Baja California" },
					new School { SchoolId = Guid.NewGuid(), Name = "UABC - Ensenada", City = "Ensenada", State = "Baja California" },
					new School { SchoolId = Guid.NewGuid(), Name = "XOCHICALCO UNIVERSIDAD - Mexicali", City = "Mexicali", State = "Baja California" },
					new School { SchoolId = Guid.NewGuid(), Name = "CETYS UNIVERSIDAD - Mexicali", City = "Mexicali", State = "Baja California" },
					new School { SchoolId = Guid.NewGuid(), Name = "CETYS UNIVERSIDAD - Tijuana", City = "Tijuana", State = "Baja California" }
			};

			modelBuilder.Entity<School>().HasData(schoolList);

			modelBuilder.Entity<Student>().HasData(
				new Student { StudentId = Guid.NewGuid(), Name = "Jorge Apodaca", SchoolId = schoolList[0].SchoolId, Score = 100 },
				new Student { StudentId = Guid.NewGuid(), Name = "Claudia Rosales", SchoolId = schoolList[0].SchoolId, Score = 85 },
				new Student { StudentId = Guid.NewGuid(), Name = "Ricardo Beltran", SchoolId = schoolList[0].SchoolId, Score = 89 },

				new Student { StudentId = Guid.NewGuid(), Name = "Saul Rodriguez", SchoolId = schoolList[1].SchoolId, Score = 95 },
				new Student { StudentId = Guid.NewGuid(), Name = "Felipe Gonzalez", SchoolId = schoolList[1].SchoolId, Score = 92 },
				new Student { StudentId = Guid.NewGuid(), Name = "Alberto Medina", SchoolId = schoolList[1].SchoolId, Score = 77 },

				new Student { StudentId = Guid.NewGuid(), Name = "Pedro Jimenez", SchoolId = schoolList[2].SchoolId, Score = 87 },
				new Student { StudentId = Guid.NewGuid(), Name = "Samanta Lopez", SchoolId = schoolList[2].SchoolId, Score = 75 },
				new Student { StudentId = Guid.NewGuid(), Name = "Francisco Mendoza", SchoolId = schoolList[2].SchoolId, Score = 54 },

				new Student { StudentId = Guid.NewGuid(), Name = "Santiago Ojeda", SchoolId = schoolList[3].SchoolId, Score = 90 },
				new Student { StudentId = Guid.NewGuid(), Name = "Raul Farias", SchoolId = schoolList[3].SchoolId, Score = 86 },
				new Student { StudentId = Guid.NewGuid(), Name = "Manuel Lopez", SchoolId = schoolList[3].SchoolId, Score = 80 },

				new Student { StudentId = Guid.NewGuid(), Name = "Guadalupe Ortiz", SchoolId = schoolList[4].SchoolId, Score = 70 },
				new Student { StudentId = Guid.NewGuid(), Name = "Cristina Gutierrez", SchoolId = schoolList[4].SchoolId, Score = 96 },
				new Student { StudentId = Guid.NewGuid(), Name = "Omar Reyes", SchoolId = schoolList[4].SchoolId, Score = 67 },

				new Student { StudentId = Guid.NewGuid(), Name = "Jose Osuna", SchoolId = schoolList[5].SchoolId, Score = 88 },
				new Student { StudentId = Guid.NewGuid(), Name = "Patricia Acosta", SchoolId = schoolList[5].SchoolId, Score = 87 },
				new Student { StudentId = Guid.NewGuid(), Name = "Alma Lopez", SchoolId = schoolList[5].SchoolId, Score = 94 }
			);
		}
    }
}