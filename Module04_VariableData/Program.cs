namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string message = "Hello there!";

			int first_h = message.ToLower().IndexOf('h');
			int last_h = message.ToLower().LastIndexOf('h');

			Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h}, and the last 'h' is at position {last_h}.");


			// Retrieving last occurrence of a sub string
			Console.WriteLine("");
			string message1 = "(What if) I am (only interested) in the last (set of parantheses)?";

			int lastOpenBracket = message1.LastIndexOf("(");
			int lastCloseBracket = message1.LastIndexOf(")");

			lastOpenBracket += 1;

			int length1 = lastCloseBracket - lastOpenBracket;
			Console.WriteLine(message1.Substring(lastOpenBracket, length1));


			// Retrieve all instances of substrings inside parentheses.
			Console.WriteLine("");
			string message2 = "(What if) there are (more than) one (set of parantheses)?";

			while (true)
			{
				int openBrackets = message2.IndexOf('(');
				if (openBrackets == -1)
				{
					break;
				}
				openBrackets += 1;
				int closeBrackets = message2.IndexOf(')');
				int length2 = closeBrackets - openBrackets;
				Console.WriteLine(message2.Substring(openBrackets, length2));

				message2 = message2.Substring(closeBrackets + 1);
			}


			// Different types of symbol set with IndexOfAny
			Console.WriteLine("");
			string message3 = "Hello, world!";
			char[] charsToFind = ['a', 'e', 'i'];

			int index = message3.IndexOfAny(charsToFind);
			Console.WriteLine($"Found '{message3[index]}' in '{message3}' at index: {index}.");


			// Another example
			Console.WriteLine("\n---Another Example---");
			string message4 = "(What if) I have [money] to buy {more RAM} and {gacha pulls}?";
			Console.WriteLine($"This is the message: {message4}\n");
			// the char list you wanna look for
			char[] openSymbols = ['(', '[', '{'];
			int closingPos = 0;

			while (true)
			{
				int openPos = message4.IndexOfAny(openSymbols, closingPos); // the closing position here is used as a starting position for the next iteration.
				if (openPos == -1)
				{
					break;
				}

				string currentSymbol = message4.Substring(openPos, 1);
				char matchingClose = ' ';

				switch (currentSymbol)
				{
					case "(":
						matchingClose = ')';
						break;
					case "[":
						matchingClose = ']';
						break;
					case "{":
						matchingClose = '}';
						break;
				}

				openPos += 1;
				closingPos = message4.IndexOf(matchingClose, openPos);

				int length4 = closingPos - openPos;
				Console.WriteLine($"This message is inside {currentSymbol}{matchingClose}:");
				Console.WriteLine(message4.Substring(openPos, length4));
				Console.WriteLine("");
			}
		}
	}
}
