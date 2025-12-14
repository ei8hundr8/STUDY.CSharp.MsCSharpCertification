void ThreeRoyalDice()
{
	Random random = new Random();
	for (int i = 0; i < 3; i++)
	{
		Console.Write($"[{random.Next(1, 21)}] ");
	}
	Console.WriteLine();
}

Console.WriteLine("Rolling the dices...");

string[] waitSymbols = [". ", ".. ", "... ", ".... "];
for (int i = 0; i < 3; i++)
{
	foreach (string symbol in waitSymbols)
	{
		Console.Write($"\r{symbol}");
		Thread.Sleep(250);
	}
	Console.Write($"\r{new String(' ', Console.BufferWidth)}");
}
ThreeRoyalDice();
Console.WriteLine("\nThe Royal Dices have spoken...");
