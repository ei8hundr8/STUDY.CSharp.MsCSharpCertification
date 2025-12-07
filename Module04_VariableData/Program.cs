namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*int first = 2;
			string second = "4";
			string result = first + second;
			Console.WriteLine(result);*/

			/*int myInt = 3;
			Console.WriteLine($"Int: {myInt}");

			decimal myDec = myInt;
			Console.WriteLine($"Decimal: {myDec}");*/

			/*decimal myDec = 3.14m;
			Console.WriteLine($"Decimal: {myDec}");

			int myInt = (int)myDec;
			Console.WriteLine($"Int: {myInt}");*/

			/*decimal myDec = 1.23456789m;
			float myFloat = (float)myDec;

			Console.WriteLine($"Decimal: {myDec}\nFloat: {myFloat}");*/

			/*int first = 5;
			int second = 7;
			string message = first.ToString() + second.ToString();
			Console.WriteLine(message);*/

			/*string first = "blue";
			string second = "9";
			int total = int.Parse(first) + int.Parse(second);
			Console.WriteLine(total);*/

			/*string num1 = "23";
			string num2 = "27";
			int total = Convert.ToInt32(num1) + Convert.ToInt32(num2);
			Console.WriteLine(total);*/

			// difference between convert and casting
			int value1 = (int)1.5m;
			int value2 = Convert.ToInt32(1.5m);
			Console.WriteLine($"Value 1: {value1}\nValue 2: {value2}");
		}
	}
}
