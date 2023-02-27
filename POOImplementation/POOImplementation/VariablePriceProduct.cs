namespace POOImplementation
{
	public class VariablePriceProduct : Product
	{
		public float Quantity { get; set; }
		public string Measurement { get; set; }
		public override decimal ValueToPay()
		{
			decimal valueToPay = Price * (decimal)Quantity;
			return valueToPay + (valueToPay * (decimal)Tax);
		}
		public override string ToString()
		{
			return $"{base.ToString()}" +
				$"\n\tMeasurement: {$"{Measurement}", 18}" +
				$"\n\tQuantity...:{$"{Quantity:F2} kg", 18}" +
				$"\n\tPrice......: {$"{Price:C2}", 18}" +
				$"\n\tTax........: {$"{Tax:P2}",18}" +
				$"\n\tValue......: {$"{ValueToPay():C2}",18}";
		}
	}
}
