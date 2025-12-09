namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*string message = "Find what is (inside the parentheses)";

			int openingPosition = message.IndexOf('(');
			int closingPosition = message.IndexOf(')');

			// Console.WriteLine(openingPosition);
			// Console.WriteLine(closingPosition);
			openingPosition += 1;
			int length = closingPosition - openingPosition;
			Console.WriteLine(message.Substring(openingPosition, length));*/

			/*string message = "What is the value <span>between the tags</span>?";

			int openingPosition = message.IndexOf("<span>");
			int closingPosition = message.IndexOf("</span>");

			Console.WriteLine(openingPosition);
			Console.WriteLine(closingPosition);

			openingPosition += 6; // 6 is from the length of the opening <span>, but this is magic number. We don't do that here.

			int length = closingPosition - openingPosition;
			Console.WriteLine(message.Substring(openingPosition, length));*/


			string message = "What is the value <span>between the tags</span>?";

			const string openSpan = "<span>";
			const string closeSpan = "</span>";

			int openingPosition = message.IndexOf(openSpan);
			int closingPosition = message.IndexOf(closeSpan);

			openingPosition += openSpan.Length;

			int length = closingPosition - openingPosition;
			Console.WriteLine(message.Substring(openingPosition, length));
		}
	}
}
