using System;

public class Exercise35
{
	public static void Main()
	{
		string data = "Hello how are you?";
		string[] words = data.Split(new[] { " " }, StringSplitOptions.None);
		if(String.Compare(words[0],"Hello")==0)
		{
			Console.WriteLine("True");
		}
		else
		{
			Console.WriteLine("False");
		}
	}
}