double total = 0;
double minSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
	total += GetDiscountedPrice(i);
}

total -= TotalMeetsMin() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
	// Calculate the discounted price for the item
	return items[itemIndex] * (1 - discounts[itemIndex]);
}
bool TotalMeetsMin()
{
	// Check if the total meets the min requirement
	return total >= minSpend;
}
string FormatDecimal(double input)
{
	// Format the double so only 2 decimal places are displayed
	return input.ToString().Substring(0, 5);
}
