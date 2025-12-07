namespace Module04_VariableData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int val_A = 2;
			int val_B = val_A;
			val_B = 5;

			Console.WriteLine("---Value Types---");
			Console.WriteLine($"Value A: {val_A}\nValue B: {val_B}");

			int[] ref_A = new int[1];
			ref_A[0] = 2;
			int[] ref_B = ref_A;
			ref_B[0] = 5;

			Console.WriteLine("---Reference Types---");
			Console.WriteLine($"Ref A: {ref_A[0]}\nRef B: {ref_B[0]}");


		}
	}
}
