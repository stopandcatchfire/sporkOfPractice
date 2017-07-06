using System;
public class Exercise8
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter a number to show Multiplication Table:");
		int num = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter number to go to (usage 0-x):");
		int mult = int.Parse(Console.ReadLine());
		
		for(int i = 0; i<mult+1; i++){
			Console.WriteLine(num+" * "+i+" = "+(num*i));
		}
	}
}