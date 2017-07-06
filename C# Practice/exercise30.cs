using System;

public class Exercise30
{
	public static void Main()
	{
		string inputHex;
		int outputDec;
		Console.WriteLine("Enter a series of Hex digits (usage:0-F):");
		inputHex = Console.ReadLine();
		outputDec = Convert.ToInt32(inputHex, 16);
		Console.WriteLine(outputDec);
	}
}