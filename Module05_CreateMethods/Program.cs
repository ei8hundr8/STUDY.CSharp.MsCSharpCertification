// Create a method that returns boolean

string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("---Palindrome Checker---");

foreach (string word in words)
{
	Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
	int start = 0;
	int end = word.Length - 1;

	while (start < end)
	{
		if (word[start] != word[end])
		{
			return false;
		}
		start++;
		end--;
	}
	return true;
}
