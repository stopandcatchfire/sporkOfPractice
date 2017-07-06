public class Exercise5
{
	public static void Main(string[] args)
	{
		int number1, number2, temp;
		System.Console.Write("\nEnter first Number: \n");
		number1 = int.Parse(System.Console.ReadLine());
		System.Console.Write("Enter the second Number: \n");
		number2 = int.Parse(System.Console.ReadLine());
		temp = number1;
		number1 = number2;
		number2 = temp;
		System.Console.WriteLine("Numbers after Swap: \n");
		System.Console.WriteLine("Number 1: " + number1 + "\n");
		System.Console.WriteLine("Number 2: " + number2 + "\n");
		//Console.Read();
	}
}