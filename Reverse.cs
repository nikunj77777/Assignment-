using System ;

class Reverse 
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter a number you want Reverse of :");
		int n = Convert.ToInt32(Console.ReadLine());
		int rev=0,rem;
		while(n!=0)
		{
			rem=n%10;
			rev=rev*10+rem;
			n/=10;
		}
		Console.WriteLine("Reversed Integer :"+rev);
	}
}