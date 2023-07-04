using System ;

class Factorial 
{
	public static void Main(String[] args)
	{
		int fact=1;
		int i =1;
		Console.WriteLine("Enter a number you want factorial of :");
		int n = Convert.ToInt32(Console.ReadLine());
		for (i=1;i<=n;i++)
		{
			fact*=i;
		}
		Console.WriteLine("Factorial is "+fact);
	}
}