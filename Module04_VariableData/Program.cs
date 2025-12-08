namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = "Pad this, Mi-chan!";
			string input2 = "How about padding this?";
			Console.WriteLine(input.PadLeft(25)); // the number inside Pad is the total number of characters for the output. Let's say the input is only 4 chars, then PadLeft(8) will add 4 extra chars to complete the total 8
			Console.WriteLine(input2.PadRight(26));

			// Overloaded method
			string input3 = "Special Padding Left!";
			string input4 = "Special Padding RIght!";
			Console.WriteLine(input3.PadLeft(30, '~'));
			Console.WriteLine(input4.PadRight(31, '!'));
			Console.WriteLine("");

			// Padded strings
			/*Suppose you work for a payment processing company that still supports legacy mainframe systems.
			 * Often, those systems require data to be input in specific columns.
			 * For example, store the Payment ID in columns 1 through 6, the payee's name in columns 7 through 30, 
			 * and the Payment Amount in columns 31 through 40. Also, importantly, the Payment Amount is right-aligned.
			 */
			string paymentID = "769C";
			string payeeName = "Mr. Stephen Ortega";
			string paymentAmount = "$5000.00";

			var formattedLine = paymentID.PadRight(6);
			formattedLine += payeeName.PadRight(24);
			formattedLine += paymentAmount.PadRight(10);

			Console.WriteLine("1234567890123456789012345678901234567890");
			Console.WriteLine(formattedLine);
		}
	}
}
