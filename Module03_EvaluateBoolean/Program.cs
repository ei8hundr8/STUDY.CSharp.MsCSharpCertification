namespace Module03_EvaluateBoolean
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Here are the rules for the battle game that you need to implement in your code project:
			 * You must use either the do-while statement or the while statement as an outer game loop.
			 * The hero and the monster start with 10 health points.
			 * All attacks are a value between 1 and 10.
			 * The hero attacks first.
			 * Print the amount of health the monster lost and their remaining health.
			 * If the monster's health is greater than 0, it can attack the hero.
			 * Print the amount of health the hero lost and their remaining health.
			 * Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
			 * Print the winner.
			 * 
			 * Expected output:
			 * Monster was damaged and lost 1 health and now has 9 health.
			 * Hero was damaged and lost 1 health and now has 9 health.
			 * Monster was damaged and lost 7 health and now has 2 health.
			 * Hero was damaged and lost 6 health and now has 3 health.
			 * Monster was damaged and lost 9 health and now has -7 health.
			 * Hero wins!
			 * 
			 */

			Random random = new Random();

			int hpPlayer = 250;
			int hpEnemy = 250;
			int damage;

			// Hero must attack first.
			do
			{
				// Player can only attack when HP is above 0.
				if (hpPlayer > 0)
				{
					damage = random.Next(1, hpEnemy + 1);
					hpEnemy -= damage;
					Console.WriteLine($"Hero attacks with {damage} damage! Monster HP is now {hpEnemy}!");
				}

				// Enemy can only attack when HP is above 0.
				if (hpEnemy > 0)
				{
					damage = random.Next(1, hpPlayer + 1);
					hpPlayer -= damage;
					Console.WriteLine($"Green Slime attacks with {damage} damage! Hero's HP is now {hpPlayer}!");
				}
			}
			while (hpPlayer > 0 && hpEnemy > 0);

			// End of battle when one of the character HP is negative.
			if (hpPlayer <= 0)
			{
				Console.WriteLine("The hero fell...");
			}
			else
			{
				Console.WriteLine($"Hero wins with {hpPlayer}HP left!");
			}

		}
	}
}