namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Remove()
			string data = "12345John Smith          5000  3  ";
			string updateData = data.Remove(5, 20);
			Console.WriteLine(updateData);

			// Replace()
			Console.WriteLine("");
			string message = "I--want--to--play--my--g-a-c-h-a-!!";
			message = message.Replace("--", " ");
			message = message.Replace("-", "");
			Console.WriteLine(message);
		}
	}
}
