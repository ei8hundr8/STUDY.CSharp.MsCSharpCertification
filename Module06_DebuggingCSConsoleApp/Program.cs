/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;
Random rand = new Random();

Console.WriteLine($"The initial value was {x}, but now it's:\n");
for (int i = 0; i < 11; i++)
{
	ChangeValue(rand.Next(1, 256));
	Console.Write($" {x} |");
}

void ChangeValue(int value)
{
	x = value;
}