namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string first = "Hello";
			string second = "World";
			string result = string.Format("{0} {1}!", first, second);
			Console.WriteLine(result);
			Console.WriteLine("");

			// Formatting currency
			decimal price = 235.25m;
			int discount = 50;
			Console.WriteLine($"Price: {price:C} (Save {discount:C})");

			// Formatting numbers
			decimal measurement = 12354822354.213535214336m;
			decimal measurement2 = 325228.24165332215236M;
			Console.WriteLine($"Measurement: {measurement:N}"); // by default, N shows 2 decimal points.
			Console.WriteLine(($"Measurement 2: {measurement2:N6}"));

			// Formatting percentage
			decimal tax = .25443M;
			Console.WriteLine($"Tax Rate: {tax:P}"); // by default, 1 decimal place for :P

			// Combining format
			decimal priceReg = 69.99M;
			decimal priceSale = 29.99M;
			decimal discountPercent = priceSale / priceReg;
			Console.WriteLine(string.Format("You save {0:C} from {1:C} when you buy it now! (Discount: {2:P})!", (priceReg - priceSale), priceReg, discountPercent));
		}
	}
}
