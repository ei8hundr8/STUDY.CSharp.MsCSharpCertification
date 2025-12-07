namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Data comes in many formats. In this challenge you have to parse the individual "Order IDs", and output the "OrderIDs" sorted and tagged as "Error" if they aren't exactly four characters in length.
			 * The orderStream variable contains a string of multiple Order IDs separated by commas.
			 * Add code below the previous code to parse the "Order IDs" from the string of incoming orders and store the "Order IDs" in an array.
			 * Add code to output each "Order ID" in sorted order and tag orders that aren't exactly four characters in length as "- Error".
			 * 
			 * Your code must produce the following output: 
			 * A345
			 * B123
			 * B177
			 * B179
			 * C15     - Error
			 * C234
			 * C235
			 * G3003   - Error
			 */

			string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

			string[] orderIDs = orderStream.Split(',');
			Array.Sort(orderIDs);
			foreach (var ID in orderIDs)
			{
				if (ID.Length != 4)
				{
					Console.WriteLine(ID + "\t- Error");
				}
				else
				{
					Console.WriteLine(ID);
				}
			}
		}
	}
}
