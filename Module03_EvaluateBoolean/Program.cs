namespace Module03_EvaluateBoolean
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Code project 1 - write code that validates integer input
			 * Here are the conditions that your first coding project must implement:
			 * Your solution must include either a do-while or while iteration.
			 * Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
			 * Inside the iteration block:
			 * Your solution must use a Console.ReadLine() statement to obtain input from the user.
			 *		Your solution must ensure that the input is a valid representation of an integer.
			 *		If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
			 *		Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
			 * Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
			 * 
			 * Example Output:
			 * Enter an integer value between 5 and 10 
			 * two
			 * Sorry, you entered an invalid number, please try again
			 * 2
			 * You entered 2. Please enter a number between 5 and 10.
			 * 7
			 * Your input value (7) has been accepted.
			 */

			string? input;
			bool validEntry = false;

			Console.WriteLine("Enter a number between 5 and 10, Onii-chan!");

			do
			{
				int intInput = 0;
				bool validNumber = false;

				input = Console.ReadLine();

				if (validNumber = int.TryParse(input, out intInput))
				{
					if (intInput >= 5 && intInput <= 10)
					{
						Console.WriteLine($"You entered the number {intInput}! Way to go, Onii-chan!");
						validEntry = true;
					}
					else
					{
						Console.WriteLine($"{intInput} is not between 5 and 10, Onii-chan...");
						continue;
					}
				}
				else
				{
					Console.WriteLine($"\"{input}\" is not even a number, Onii-chan... Daijoubu?");
				}
			}
			while (validEntry == false);

		}
	}
}