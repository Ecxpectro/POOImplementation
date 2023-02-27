namespace POOImplementation
{
	public class FixedPriceProduct : Product
	{
		public override decimal ValueToPay()
		{
			return Price + (Price * (decimal)Tax);
		}
		public override string ToString()
		{
			return $"{base.ToString()}" +
				$"\n\tPrice......: {$"{Price:C2}", 18}" +
				$"\n\tTax........: {$"{Tax:P2}", 18}" +
				$"\n\tValue......: {$"{ValueToPay():C2}", 18}";
		}
	}
}
