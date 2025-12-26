/* Dice mini-game challenge
 * Your challenge is to design a mini-game. The game should select a target number that is a random number between one and five (inclusive). 
 * The player must roll a six-sided dice. 
 * To win, the player must roll a number greater than the target number. 
 * At the end of each round, the player should be asked if they would like to play again, and the game should continue or terminate accordingly.
 * 
 * In this challenge, you're given some starting code. You must determine what methods to create, their parameters, and their return types.
 * 
 * Code challenge: add methods to make the game playable 
 */

Random random = new Random();
Console.WriteLine("Would you like to play, Traveler? [Y/N]");
string? input = "";
if (ShouldPlay(input))
{
	PlayGame();
}

void PlayGame()
{
	var play = true;

	while (play)
	{
		var target = random.Next(1, 6);
		var roll = random.Next(1, 7);

		Console.WriteLine($"\nRoll a number greater than {target} to win.");
		Console.WriteLine($"You rolled a {roll}!");
		Console.WriteLine(WinOrLose());
		Console.WriteLine("\nPlay again? [Y/N]");

		play = ShouldPlay(input);

		string WinOrLose()
		{
			string result = "";
			if (roll > target)
			{
				result = "You win, Traveler!";
			}
			else if (roll < target)
			{
				result = "Oh dear, you lose...";
			}
			else
			{
				result = "Oh my, it's a draw!";
			}
			return result;
		}
	}
}

bool ShouldPlay(string? input)
{
	bool valid = true;
	do
	{
		input = Console.ReadLine();
		if (input != null)
		{
			input = input.Trim().ToLower();
			switch (input)
			{
				case "y":
				case "yes":
				case "yep":
				case "yeah":
					return true;
				case "n":
				case "no":
				case "nope":
				case "nah":
					Console.WriteLine("\nHope to see you again, dear Traveler.\nBye bye~");
					return false;
				default:
					Console.WriteLine("Invalid selection, dear Traveler.");
					valid = false;
					break;
			}
		}
		valid = false;
	} while (valid == false);
	return false;
}
