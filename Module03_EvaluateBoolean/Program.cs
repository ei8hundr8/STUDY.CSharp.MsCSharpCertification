namespace Module03_EvaluateBoolean
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int employeeLevel = 100;
			string employeeName = "John Smith";

			string title = "";

			switch (employeeLevel)
			{
				case 100:
				case 200:
					title = "Senior Associate";
					break;
				case 300:
					title = "Manager";
					break;
				case 400:
					title = "Senior Manager";
					break;
				default:
					title = "Associate";
					break;
			}
			else if (product[2] == "L")
			{
				size = "Large";
			}
			else
			{
				size = "One Size Fits All";
			}

			Console.WriteLine($"Product: {size} {color} {type}");

			Original code ends here */

			string sku = "01-BL-M";
			string[] product = sku.Split('-');

			string type;
			string color;
			string size;

			switch (product[0])
			{
				case "01":
					type = "Sweat shirt";
					break;
				case "02":
					type = "T-Shirt";
					break;
				case "03":
					type = "Sweat pants";
					break;
				default:
					type = "Other";
					break;
			}

			switch (product[1])
			{
				case "BL":
					color = "Black";
					break;
				case "MN":
					color = "Maroon";
					break;
				default:
					color = "White";
					break;
			}

			switch (product[2])
			{
				case "S":
					size = "Small";
					break;
				case "M":
					size = "Medium";
					break;
				case "L":
					size = "Large";
					break;
				default:
					size = "One Size Fits All";
					break;
			}

			Console.WriteLine($"Product: {size} {color} {type}");

			Console.WriteLine($"{employeeName}, {title}");
		}
	}
}