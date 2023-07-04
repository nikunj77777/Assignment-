using System ;

class Palindrome 
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter a number  :");
		int n = Convert.ToInt32(Console.ReadLine());
		int check = n;
		int rev=0,rem;
		while(n!=0)
		{
			rem=n%10;
			rev=rev*10+rem;
			n/=10;
		}
		if(rev==check)
		{
			Console.WriteLine("It is a Palindrome");
		}
		else
		{
			Console.WriteLine("It is not a Palindrome");
		}
		
	}
}