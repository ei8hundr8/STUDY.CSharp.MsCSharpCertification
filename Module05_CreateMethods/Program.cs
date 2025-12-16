// Use Value and Reference Type Parameters

// Test pass by value
int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"Global Statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c)
{
	c = a * b;
	Console.WriteLine($"Inside Multiply method: {a} x {b} = {c}");
}

// Test pass by reference
Console.WriteLine();
int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
	foreach (int num in array)
	{
		Console.Write($"{num} ");
	}
	Console.WriteLine();
}

void Clear(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = 0;
	}
}

// Test with strings
Console.WriteLine();
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetStatus(false);
Console.WriteLine($"End: {status}");

void SetStatus(bool isHealthy)
{
	status = (isHealthy ? "Healthy" : "Unhealthy");
	Console.WriteLine($"Middle: {status}");
}
