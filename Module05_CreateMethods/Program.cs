string[] guestList = { "Loen", "Neon", "Rapi", "Cindy", "Leviathan" };
string[] rsvps = new string[10];
int count = 0;

void RSVP(string name, int partySize, string allergies, bool inviteOnly)
{
	if (inviteOnly)
	{
		// search guestList before adding rsvps
		bool found = false;
		foreach (string guest in guestList)
		{
			if (guest.Equals(name))
			{
				found = true;
				break;
			}
		}
		if (!found)
		{
			Console.WriteLine($"Sorry, {name} is not on the guest list.");
			return;
		}
	}
	rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
	count++;
}
void ShowRSVPs()
{
	Console.WriteLine("\nTotal RSVPs:");
	for (int i = 0; i < count; i++)
	{
		Console.WriteLine(rsvps[i]);
	}
}

RSVP("Jonte", 1, "none", true);
RSVP("Neon", 2, "Nuts", true);
RSVP("Cindy", 2, "none", false);
RSVP("Loen", 1, "Jackfruit", true);
RSVP("Rapi", 4, "none", false);
RSVP("Leviathan", 2, "Stone fruit", false);
ShowRSVPs();