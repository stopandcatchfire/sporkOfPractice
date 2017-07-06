using System;

public class Exercise28
{
	public static void Main()
	{
		string str = Console.ReadLine();
		string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
		
		for(int i = words.Length-1; i>=0; i--)
		{
			if(i>=0){
				Console.Write(words[i]+" ");
			}
			else{
				Console.Write(words[i]);
			}
		}
	}
}