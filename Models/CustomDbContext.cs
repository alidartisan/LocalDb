using Microsoft.EntityFrameworkCore;

namespace MvcLocalDb.Models
{
	public class CustomDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Staff> Staff { get; set; }
		public DbSet<FeeRecord> FeeRecord { get; set; }

		public CustomDbContext(DbContextOptions<CustomDbContext> option) :base(option) { }

	}
}
