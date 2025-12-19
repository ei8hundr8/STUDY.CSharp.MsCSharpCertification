/*Your challenge is to create a method that displays the correct email address for both internal and external employees.
 *You're given lists of internal and external employee names. An employee's email address consists of their username and company domain name.
 *The username format is the first two characters of the employee first name, followed by their last name. 
 *For example, an employee named "Robert Bavin" would have the username "robavin". The domain for internal employees is "contoso.com".
 *In this challenge, you're given some starting code. You must decide how to create and call a method to display email addresses.
 *
 *Expected Output:
 *robavin@contoso.com
 *sibright@contoso.com
 *kisinclair@contoso.com
 *aakamath@contoso.com
 *sadelucchi@contoso.com
 *siali@contoso.com
 *viashton@hayworth.com
 *codysart@hayworth.com
 *shlawrence@hayworth.com
 *davaldes@hayworth.com
 */

string[,] corporate =
{
		{"Robert", "Bavin"}, {"Simon", "Bright"},
		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
		{"Sarah", "Delucchi"}, {"Sinan", "Ali"},{"Vivian","Banshee"}
};

string[,] external =
{
		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

void EmployeeInternal()
{
	for (int i = 0; i < corporate.GetLength(0); i++)
	{
		// display internal email addresses
		string firstName = corporate[i, 0].ToLower().Substring(0, 2);
		string lastName = corporate[i, 1].ToLower();
		string emailInter = firstName + lastName + "@contoso.com";

		Console.WriteLine(emailInter);
	}
}

void EmployeeExternal()
{
	for (int i = 0; i < external.GetLength(0); i++)
	{
		// display external email addresses
		string firstName = external[i, 0].ToLower().Substring(0, 2);
		string lastName = external[i, 1].ToLower();
		string emailExter = firstName + lastName + "@" + externalDomain;
		Console.WriteLine(emailExter);
	}
}

Console.WriteLine("---Internal Employee---");
EmployeeInternal();
Console.WriteLine("\n---External Employee---");
EmployeeExternal();

// Microsoft answer below
Console.WriteLine("\n---Example Answer---");

for (int i = 0; i < corporate.GetLength(0); i++)
{
	DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
	DisplayEmail(first: external[i, 0], last: external[i, 1], externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com")
{
	string email = first.Substring(0, 2) + last;
	email = email.ToLower();
	Console.WriteLine($"{email}@{domain}");
}