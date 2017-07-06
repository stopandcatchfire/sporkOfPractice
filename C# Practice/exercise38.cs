using System;

public class Exercise38
{
	public static void Main()
	{
		int i = 0;
		Console.WriteLine("Enter length of your array:");
		int arrayLength = int.Parse(Console.ReadLine());
		int[] arr = new int[arrayLength];
		Random rand = new Random();
		Console.Write("Array1: [");
		for(i=0; i<arrayLength; i++)
		{
			arr[i] = rand.Next(0,1000);
			if(i==arrayLength-1)
			{
				Console.WriteLine(arr[i]+"]");
			}
			else
				Console.Write(arr[i]+", ");
		}
		
		Console.Write("After rotating array becomes: [");
		int[] arr2 = new int[arrayLength];
		arr2[arrayLength-1] = arr[0];
		for(i=0; i<arrayLength-1; i++){
			arr2[i] = arr[i+1];
			Console.Write(arr2[i]+", ");
		}
		Console.Write(arr2[arrayLength-1]+"]");
	}
}
		