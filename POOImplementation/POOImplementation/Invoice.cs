namespace POOImplementation
{
	public class Invoice : IPay
	{
		private readonly List<Product> _products = new List<Product>(0);
		public Invoice()
		{
			
		}
	

		public List<Product> AddProduct(Product product)
		{
			try
			{
				_products.Add(product);
			}
			catch (Exception ex)
			{

				
			}
			

			return _products;
		}

		public decimal ValueToPay()
		{
			decimal valueToPay = 0;

			foreach (Product product in _products)
			{
				valueToPay = valueToPay + product.ValueToPay();
			}

			return valueToPay;
		}
		public override string ToString()
		{
			string products = "";
			foreach (Product product in _products)
			{
				products+= "\n" + product.ToString();
			}
			return 	"RECEIPT" +
				"\n-----------------------------------------------------------------" +
				$"{products}" +
				$"\n\t            =============" +
				$"\n\tTOTAL: {$"{ValueToPay():C2}", 18}";
		}
	}
}
