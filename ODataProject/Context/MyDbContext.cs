using Microsoft.EntityFrameworkCore;
using ODataProject.Models;
using ODataProject.Models.Seed;

namespace ODataProject.Context
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
		{
		}

		public DbSet<School> Schools { get; set; }
		public DbSet<Student> Students { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<School>()
				.Property(x => x.SchoolId)
				.HasDefaultValueSql("NEWID()");
			modelBuilder.Entity<Student>()
				.Property(x => x.StudentId)
				.HasDefaultValueSql("NEWID()");

			modelBuilder.Seed();
		}
	}
}
