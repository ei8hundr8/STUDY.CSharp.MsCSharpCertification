namespace Module03_EvaluateBoolean
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int coinToss = random.Next(1, 3);

			//string coinResult = coinToss == 1 ? "Head" : "Tail";
			Console.WriteLine($"You got {(coinToss == 1 ? "Head" : "Tail")}!");
		}
	}
}
