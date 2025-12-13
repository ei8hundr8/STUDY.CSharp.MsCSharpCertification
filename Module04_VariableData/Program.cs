namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Begin adding your solution code to the starter code under the comment // Your work here.
			 * Set the quantity variable to the value obtained by extracting the text between the <span> and </span> tags.
			 * Set the output variable to the value of input, then remove the <div> and </div> tags.
			 * Replace the HTML character ™ (&trade;) with ® (&reg;) in the output variable.
			 * Run your solution and verify the output matches the expected output.
			 * 
			 * Desired output:
			 * Quantity: 5000
			 * Output: <h2>Widgets &reg;</h2><span>5000</span>
			 */

			const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
			string quantity = "";
			string output = "";

			// My code here

			// This makes it so that i can look for the exact index of <span>
			const string openSpan = "<span>";
			const string closeSpan = "</span>";
			const string trade = "&trade";
			const string divOpen = "<div>";
			const string divClose = "</div>";

			int openPos = input.IndexOf(openSpan);
			int closePos = input.IndexOf(closeSpan);
			int openDiv = input.IndexOf(divOpen);
			int closeDiv = input.IndexOf(divClose);

			openPos += openSpan.Length; // this is so that the starting point is after the last > in <span>

			// This removes both divs
			output = input.Remove(closeDiv, divClose.Length);
			output = output.Remove(openDiv, divOpen.Length);

			// This replace the trademark
			output = $"Output: {output.Replace(trade, "&reg")}";

			quantity = $"Quantity: {input.Substring(openPos, closePos - openPos)}";

			// My code ends here
			Console.WriteLine(quantity);
			Console.WriteLine(output);

		}
	}
}
