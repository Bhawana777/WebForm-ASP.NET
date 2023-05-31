namespace WebForm.Models
{
	public class Values
	{
		public decimal Quantity { get; set; }
		public int Rate { get; set; }
		public decimal Value => Quantity * Rate;

		public decimal Total => Value;
	}
}
