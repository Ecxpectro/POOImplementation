namespace POOImplementation
{
	public abstract class Product : IPay
	{
		public string Description { get; set; }
		public long Id { get; set; }
		public decimal Price { get; set; }
		public float Tax { get; set; }

		public abstract decimal ValueToPay();

		public override string ToString()
		{
			return $"{Id} - {Description}";
		}


	}
}
