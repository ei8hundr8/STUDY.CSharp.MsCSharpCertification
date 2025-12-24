// Create a method that returns a string

string ReverseWord(string word)
{
	string result = "";

	for (int i = word.Length - 1; i >= 0; i--)
	{
		result += word[i];
	}
	return result;
}

string? input;
Console.Write("What word do you want to reverse?\t");
input = Console.ReadLine();

if (input != null)
{
	Console.WriteLine($"\nThis is your reversed word!\n{ReverseWord(input)}");
}

// Create a method to reverse words in a sentence
Console.WriteLine();

String ReverseSentence(string sentence)
{
	string result = "";
	string[] words = sentence.Split(' ');

	foreach (string word in words)
	{
		for (int i = word.Length - 1; i >= 0; i--)
		{
			result += word[i];
		}
		result += " ";
	}

	return result.Trim();
}

string? input1;
Console.WriteLine("What sentence do you want to reverse, traveler?");
input1 = Console.ReadLine();

if (input1 != null)
{
	Console.WriteLine($"\nThis is your reversed sentence!\n{ReverseSentence(input1)}");
}
