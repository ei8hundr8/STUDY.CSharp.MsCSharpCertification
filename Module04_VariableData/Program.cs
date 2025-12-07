namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "mi-chan";
			int result = 0;
			if (int.TryParse(value, out result))
			{
				Console.WriteLine($"Measurement: {result}");
			}
			else
			{
				Console.WriteLine("Unable to report measurement.");
			}

			if (result > 0)
			{
				Console.WriteLine($"Measurement (w/ offset): {result + 25}");
			}

		}
	}
}
