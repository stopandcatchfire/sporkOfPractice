using System;

public class Exercise25
{
	public static void Main()
	{
		int flg = 1;
		for(int i=0; i<100; i++)
		{
			if(flg==0)
			{
				Console.WriteLine(i);
				flg = 1;
			}
			else
				flg = 0;
		}
	}
}