using System;
using System.Collections.Generic;

public class Exercise15
{
	static void Main(string[] args)
	{
		Random rnd = new Random();
		Console.WriteLine("enter a string to play with:");
		string str = Console.ReadLine();
		int leng = str.Length;
		Console.WriteLine("how many plays?:(1-str.length-1)");
		int len = int.Parse(Console.ReadLine());
		if(len>leng)
		{
			Console.WriteLine("Error!");
		
		}
		
		for(int i = 0; i<len; i++)
		{
			Console.WriteLine(remove_char(str, rnd.Next(0,str.Length)));
		}
	}
	
	public static string remove_char(string stri, int n)
	{
		return stri.Remove(n,1);
	}
	
	
}
		