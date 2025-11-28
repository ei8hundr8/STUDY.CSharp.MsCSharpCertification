namespace Module03_EvaluateBoolean
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i <= 50; i += 5)
			{
				Console.WriteLine(i);
				if (i == 10) break;
			}
		}
	}
}