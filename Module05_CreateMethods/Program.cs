string[] students = { "Loen", "Teressa", "Priestess", "Cinderella" };

DisplayStudents(students);
DisplayStudents(new string[] { "Vitya", "Morpheah" });

void DisplayStudents(string[] students)
{
	foreach (string student in students)
	{
		Console.Write($"{student}, ");
	}
	Console.WriteLine();
}
Console.WriteLine();
// Next section

double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(13);
PrintCircleInfo(21);

void PrintCircleArea(int radius)
{
	double area = pi * (radius * radius);
	Console.WriteLine($"Area: {area}");
}

void PrintCircleCircumference(int radius)
{
	double circumference = 2 * pi * radius;
	Console.WriteLine($"Circumference: {circumference}");
}

void PrintCircleInfo(int radius)
{
	Console.WriteLine($"Circle with Radius: {radius}");
	PrintCircleArea(radius);
	PrintCircleCircumference(radius);
}