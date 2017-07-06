using System;
public class exercise7
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the first number:");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the second number:");
		int b = int.Parse(Console.ReadLine());
		Console.WriteLine(a+" + "+b+" = "+(a+b));
		Console.WriteLine(a+" - "+b+" = "+(a-b));
		Console.WriteLine(a+" X "+b+" = "+(a*b));
		Console.WriteLine(a+" / "+b+" = "+(a/b));
		Console.WriteLine(a+" mod "+b+" = "+(a%b));
	}
}