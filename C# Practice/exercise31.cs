using System;

public class Exercise31
{
	public static void Main()
	{
		int[] one = new int[4];
		int[] two = new int[4];
		
		Console.WriteLine("Enter four values for first 1x4 array:");
		for(int i=0;i<4;i++)
		{
			one[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Enter four values for the second 1x4 array:");
		for(int i=0;i<4;i++)
		{
			two[i] = int.Parse(Console.ReadLine());
		}
		for(int i=0;i<4;i++)
		{
			if(i<3){
				Console.Write(one[i]*two[i]+", ");
			}
			else
				Console.Write(one[i]*two[i]);
		}
	}
}