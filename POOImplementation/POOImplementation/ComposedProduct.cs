namespace POOImplementation
{
	public class ComposedProduct : Product
	{
		public float Discount { get; set; }
		public List<Product> Products { get; set; }
		public override decimal ValueToPay()
		{
			decimal totalValue = 0;
			foreach (Product product in Products)
			{
				totalValue = totalValue + product.ValueToPay();

			}
			totalValue = totalValue - (totalValue * (decimal)Discount);
			return totalValue;

		}
		public override string ToString()
		{
			var products = "";
			foreach (Product product in Products)
			{
				products += product.Description + ", ";
			}
			if (products.EndsWith(", "))
			{
			products = products.Remove(products.Length - 2);
			}
			return $"{base.ToString()}" +
				$"\n\tProducts...: {products}" +
				$"\n\tDiscount...: {$"{Discount:P2}", 18}" +
				$"\n\tValue......: {$"{ValueToPay():C2}", 18}";
		}
	}
}
