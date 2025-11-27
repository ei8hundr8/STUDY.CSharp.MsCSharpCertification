namespace Module03_EvaluateBoolean
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Decision logic challenge
			In this challenge, you implement decision logic based on a series of business rules.The business rules specify the access that is granted to users based on their role - based permissions and their career level.Code branches display a different message to the user depending on their permissions and level.
			*/

			string permission = "Admin"; // Original was "Admin | Manager"
			int level = 19;

			if (permission.Contains("Admin"))
			{
				if (level > 55)
				{
					Console.WriteLine("Welcome, Super Admin user.");
				}
				else
				{
					Console.WriteLine("Welcome, Admin user.");
				}
			}
			else if (permission.Contains("Manager"))
			{
				if (level >= 20)
				{
					Console.WriteLine("Contact an Admin for access.");
				}
				else
				{
					Console.WriteLine("You do not have sufficient privileges.");
				}
			}
			else
			{
				Console.WriteLine("You do not have sufficient privileges.");
			}
		}
	}
}
