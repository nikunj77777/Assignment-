using System ;

class Armstrong 
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter a number  :");
		int n = Convert.ToInt32(Console.ReadLine());
		int check = n;
		int sum=0,rem;
		while(n!=0)
		{
			rem=n%10;
			sum=sum+(rem*rem*rem);
			n=n/10;
		}
		if(sum==check)
		{
			Console.WriteLine("It is an Armstrong Number");
		}
		else
		{
			Console.WriteLine("It is not an Armstrong Number");
		}
		
	}
}