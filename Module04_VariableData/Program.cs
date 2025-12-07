namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Write the code necessary to reverse the letters of each word in place and display the result.
			 * In other words, don't just reverse every letter in the variable pangram. 
			 * Instead, you need to reverse just the letters in each word, but print the reversed word in its original position in the message.
			 * 
			 * Your code must produce the following output:
			 * ehT kciuq nworb xof spmuj revo eht yzal god
			 * 
			 * This is a particularly difficult challenge. You will need to combine many of the concepts you learned in this exercise, 
			 * including the use of the Split(), ToCharArray(), Array.Reverse(), and String.Join(). 
			 * You'll also need to create multiple arrays, and at least one iteration statement.
			 */

			string pangram = "The quick brown fox jumps over the lazy dog";
			string[] segments = pangram.Split(" ");
			char[] characters;
			string message = "";

			// If we use for loop.
			/*for (int i = 0; i < segments.Length; i++)
			{
				characters = segments[i].ToCharArray(0, segments[i].Length);
				Array.Reverse(characters);
				string joinedChars = String.Join("", characters);
				message += joinedChars + " ";
			}
			Console.WriteLine(message);*/

			// If we use foreach loop.
			/*foreach (var segment in segments)
			{
				characters = segment.ToCharArray(0, segment.Length);
				Array.Reverse(characters);
				string joinedCharacters = String.Join("", characters);
				message += joinedCharacters + " ";
			}
			Console.WriteLine(message);*/

			// Provided solution:
			string[] pangram1 = pangram.Split(' ');
			string[] newPangram = new string[pangram1.Length];

			for (int i = 0; i < pangram1.Length; i++)
			{
				char[] letters = pangram1[i].ToCharArray();
				Array.Reverse(letters);
				newPangram[i] = new string(letters);
			}
			string result = String.Join(" ", newPangram);
			Console.WriteLine(result);

		}
	}
}
