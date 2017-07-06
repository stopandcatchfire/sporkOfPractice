using System;
using System.Collections.Generic;
using System.IO;

public class Exercise29
{
	public static void Main(){
	FileInfo f = new FileInfo("/Users/nwant/Documents/C# Practice/exercise8.cs");
	Console.WriteLine("\nSize of file: " + f.Length.ToString());
	}
}