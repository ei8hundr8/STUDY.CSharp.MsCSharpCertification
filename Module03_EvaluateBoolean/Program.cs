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
			*/

			/* Code project 3 - Write code that processes the contents of a string array
			 * Here are the conditions that your third coding project must implement:
			 * your solution must use the following string array to represent the input to your coding logic:
			 * string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
			 * Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.
			 * Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.
			 * In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.
			 * Your solution must include an inner do-while or while loop that can be used to process the myString variable.
			 * In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
			 * In the inner loop, your solution must not display the period character.
			 * In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
			 * 
			 * Example Output:
			 * I like pizza
			 * I like roast chicken
			 * I like salad
			 * I like all three of the menu choices
			 */

			string[] myStrings = { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices", "I like Vivian. I like Rapi. I like Alice. I like Mi-chan. Mi-chan like ice cream from Nyan Nyan Ice Cream Cafe" };
			int periodLocation = 0;

			foreach (string myString in myStrings)
			{
				string line;
				string clean = myString; // This is kinda like working on a git branch. I'm creating a clean branch to not dirty myString.

				periodLocation = clean.IndexOf(".");
				while (periodLocation != -1)
				{

					// This is the output line.
					line = clean.Remove(periodLocation);

					// This is cleanup and update the period to the next one.
					clean = clean.Substring(periodLocation + 1).TrimStart();
					periodLocation = clean.IndexOf(".");

					// Flow: Output the line first, then cleanup, and finally update the period location index.
					Console.WriteLine(line);
				}
				// Just in case there are white spaces wrapping the words.
				Console.WriteLine(clean.Trim());

			}
		}
	}
}