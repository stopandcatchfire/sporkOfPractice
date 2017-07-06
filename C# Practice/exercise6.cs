public class Exercise6
{
	public static void Main(string[] args)
	{
		int a,b,c,product;
		System.Console.WriteLine("Input the first Number to multiply: ");
		a = int.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Input the second Number to Multiply: ");
		b = int.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Input the third Number to Multiply: ");
		c = int.Parse(System.Console.ReadLine());
		System.Console.WriteLine(a+"X"+b+"X"+c+"="+(a*b*c));
	}
}