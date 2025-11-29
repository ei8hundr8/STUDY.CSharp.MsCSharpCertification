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
			 

			string? input;
			bool validEntry = false;

			Console.WriteLine("Enter a number between 5 and 10, Onii-chan!");

			do
			{
				int intInput = 0;

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
			*/

			/* Code project 2 - write code that validates string input:
			 * Here are the conditions that your second coding project must implement:
			 * Your solution must include either a do-while or while iteration.
			 * Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.
			 * Inside the iteration block:
			 *		Your solution must use a Console.ReadLine() statement to obtain input from the user.
			 *		Your solution must ensure that the value entered matches one of the three role options.
			 *		Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
			 *		Your solution should use the ToLower() method on the input value to ignore case.
			 *		If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
			 *		Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
			 * 
			 * Example Output:
			 * Enter your role name (Administrator, Manager, or User)
			 * Admin
			 * The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
			 * Administrator
			 * Your input value (Administrator) has been accepted.
			 */

			string? input = null;
			bool validEntry = false;

			Console.WriteLine("Please select your role.");
			Console.WriteLine("Choose between:\n1. Administrator\n2. Manager\n3. User");

			do
			{
				input = Console.ReadLine();
				string cleanInput = input.ToLower().Trim();

				switch (cleanInput)
				{
					case "administrator":
					case "admin":
						validEntry = true;
						Console.WriteLine($"Welcome, Administrator.");
						break;
					case "manager":
					case "mgr":
						validEntry = true;
						Console.WriteLine($"Welcome, Manager.");
						break;
					case "user":
					case "usr":
						validEntry = true;
						Console.WriteLine($"Welcome, User.");
						break;
					default:
						Console.WriteLine($"\"{cleanInput}\" is not a valid role. Please enter either (Administrator, Manager, or User.");
						continue;
				}

			}
			while (validEntry == false);

		}
	}
}