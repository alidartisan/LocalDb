namespace MvcLocalDb.Models
{
	public class FeeRecord
	{
		public int Id { get; set; }
		public int StdId { get; set; }
		public string FeeType { get; set; }
		public DateOnly FeeMonth { get; set; }
		public DateOnly FeeYear { get; set; }
		public int FeeAmount { get; set; }
		public int FeeBalance { get; set; }
		public int Fine { get; set; }

	}
}
