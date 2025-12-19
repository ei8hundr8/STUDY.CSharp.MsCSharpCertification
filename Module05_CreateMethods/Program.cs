// Create a method that returns an integer

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${usd} USD");

int UsdToVnd(double usd)
{
	int rate = 23500;
	return (int)(usd * rate);
}

// Create a method that returns a double
Console.WriteLine();

double VndToUsd(int vnd)
{
	double rate = 23500;
	return (double)(vnd / rate);
}