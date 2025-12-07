namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "abc123";
			char[] valueArray = value.ToCharArray();

			Array.Reverse(valueArray);
			// string result = new string(valueArray);
			string result = string.Join(',', valueArray);
			Console.WriteLine(result);

			string[] items = result.Split(',');
			foreach (var item in items)
			{
				Console.WriteLine(item);
			}
		}
	}
}
